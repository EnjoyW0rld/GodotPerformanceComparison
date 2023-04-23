using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Tweens are useful for animations requiring a numerical property to be interpolated over a range of values. The name tween comes from in-betweening, an animation technique where you specify keyframes and the computer interpolates the frames that appear between them.</para>
    /// <para><see cref="Godot.Tween"/> is more suited than <see cref="Godot.AnimationPlayer"/> for animations where you don't know the final values in advance. For example, interpolating a dynamically-chosen camera zoom value is best done with a <see cref="Godot.Tween"/> node; it would be difficult to do the same thing with an <see cref="Godot.AnimationPlayer"/> node.</para>
    /// <para>Here is a brief usage example that makes a 2D node move smoothly between two positions:</para>
    /// <para><code>
    /// var tween = get_node("Tween")
    /// tween.interpolate_property($Node2D, "position",
    ///         Vector2(0, 0), Vector2(100, 100), 1,
    ///         Tween.TRANS_LINEAR, Tween.EASE_IN_OUT)
    /// tween.start()
    /// </code></para>
    /// <para>Many methods require a property name, such as <c>"position"</c> above. You can find the correct property name by hovering over the property in the Inspector. You can also provide the components of a property directly by using <c>"property:component"</c> (e.g. <c>position:x</c>), where it would only apply to that particular component.</para>
    /// <para>Many of the methods accept <c>trans_type</c> and <c>ease_type</c>. The first accepts an <see cref="Godot.Tween.TransitionType"/> constant, and refers to the way the timing of the animation is handled (see <a href="https://easings.net/">easings.net</a> for some examples). The second accepts an <see cref="Godot.Tween.EaseType"/> constant, and controls where the <c>trans_type</c> is applied to the interpolation (in the beginning, the end, or both). If you don't know which transition and easing to pick, you can try different <see cref="Godot.Tween.TransitionType"/> constants with <see cref="Godot.Tween.EaseType.InOut"/>, and use the one that looks best.</para>
    /// <para><a href="https://raw.githubusercontent.com/godotengine/godot-docs/master/img/tween_cheatsheet.png">Tween easing and transition types cheatsheet</a></para>
    /// <para>Note: Tween methods will return <c>false</c> if the requested operation cannot be completed.</para>
    /// <para>Note: For an alternative method of tweening, that doesn't require using nodes, see <see cref="Godot.SceneTreeTween"/>.</para>
    /// </summary>
    public partial class Tween : Node
    {
        public enum TransitionType
        {
            /// <summary>
            /// <para>The animation is interpolated linearly.</para>
            /// </summary>
            Linear = 0,
            /// <summary>
            /// <para>The animation is interpolated using a sine function.</para>
            /// </summary>
            Sine = 1,
            /// <summary>
            /// <para>The animation is interpolated with a quintic (to the power of 5) function.</para>
            /// </summary>
            Quint = 2,
            /// <summary>
            /// <para>The animation is interpolated with a quartic (to the power of 4) function.</para>
            /// </summary>
            Quart = 3,
            /// <summary>
            /// <para>The animation is interpolated with a quadratic (to the power of 2) function.</para>
            /// </summary>
            Quad = 4,
            /// <summary>
            /// <para>The animation is interpolated with an exponential (to the power of x) function.</para>
            /// </summary>
            Expo = 5,
            /// <summary>
            /// <para>The animation is interpolated with elasticity, wiggling around the edges.</para>
            /// </summary>
            Elastic = 6,
            /// <summary>
            /// <para>The animation is interpolated with a cubic (to the power of 3) function.</para>
            /// </summary>
            Cubic = 7,
            /// <summary>
            /// <para>The animation is interpolated with a function using square roots.</para>
            /// </summary>
            Circ = 8,
            /// <summary>
            /// <para>The animation is interpolated by bouncing at the end.</para>
            /// </summary>
            Bounce = 9,
            /// <summary>
            /// <para>The animation is interpolated backing out at ends.</para>
            /// </summary>
            Back = 10
        }

        public enum TweenProcessMode
        {
            /// <summary>
            /// <para>The tween updates with the <c>_physics_process</c> callback.</para>
            /// </summary>
            Physics = 0,
            /// <summary>
            /// <para>The tween updates with the <c>_process</c> callback.</para>
            /// </summary>
            Idle = 1
        }

        public enum EaseType
        {
            /// <summary>
            /// <para>The interpolation starts slowly and speeds up towards the end.</para>
            /// </summary>
            In = 0,
            /// <summary>
            /// <para>The interpolation starts quickly and slows down towards the end.</para>
            /// </summary>
            Out = 1,
            /// <summary>
            /// <para>A combination of <see cref="Godot.Tween.EaseType.In"/> and <see cref="Godot.Tween.EaseType.Out"/>. The interpolation is slowest at both ends.</para>
            /// </summary>
            InOut = 2,
            /// <summary>
            /// <para>A combination of <see cref="Godot.Tween.EaseType.In"/> and <see cref="Godot.Tween.EaseType.Out"/>. The interpolation is fastest at both ends.</para>
            /// </summary>
            OutIn = 3
        }

        /// <summary>
        /// <para>If <c>true</c>, the tween loops.</para>
        /// </summary>
        public bool Repeat
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRepeat();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRepeat(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The tween's animation process thread. See <see cref="Godot.Tween.TweenProcessMode"/>.</para>
        /// </summary>
        public Tween.TweenProcessMode PlaybackProcessMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTweenProcessMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTweenProcessMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The tween's speed multiplier. For example, set it to <c>1.0</c> for normal speed, <c>2.0</c> for two times normal speed, or <c>0.5</c> for half of the normal speed. A value of <c>0</c> pauses the animation, but see also <see cref="Godot.Tween.SetActive"/> or <see cref="Godot.Tween.StopAll"/> for this.</para>
        /// </summary>
        public float PlaybackSpeed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpeedScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpeedScale(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Tween";

        public Tween() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Tween_Ctor(this);
        }

        internal Tween(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_active");

        /// <summary>
        /// <para>Returns <c>true</c> if any tweens are currently running.</para>
        /// <para>Note: This method doesn't consider tweens that have ended.</para>
        /// </summary>
        [GodotMethod("is_active")]
        public bool IsActive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_active");

        /// <summary>
        /// <para>Activates/deactivates the tween. See also <see cref="Godot.Tween.StopAll"/> and <see cref="Godot.Tween.ResumeAll"/>.</para>
        /// </summary>
        [GodotMethod("set_active")]
        public void SetActive(bool active)
        {
            NativeCalls.godot_icall_1_16(method_bind_1, Object.GetPtr(this), active);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_repeat");

        [GodotMethod("is_repeat")]
        [Obsolete("IsRepeat is deprecated. Use the Repeat property instead.")]
        public bool IsRepeat()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_repeat");

        [GodotMethod("set_repeat")]
        [Obsolete("SetRepeat is deprecated. Use the Repeat property instead.")]
        public void SetRepeat(bool repeat)
        {
            NativeCalls.godot_icall_1_16(method_bind_3, Object.GetPtr(this), repeat);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_speed_scale");

        [GodotMethod("set_speed_scale")]
        [Obsolete("SetSpeedScale is deprecated. Use the PlaybackSpeed property instead.")]
        public void SetSpeedScale(float speed)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), speed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_speed_scale");

        [GodotMethod("get_speed_scale")]
        [Obsolete("GetSpeedScale is deprecated. Use the PlaybackSpeed property instead.")]
        public float GetSpeedScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tween_process_mode");

        [GodotMethod("set_tween_process_mode")]
        [Obsolete("SetTweenProcessMode is deprecated. Use the PlaybackProcessMode property instead.")]
        public void SetTweenProcessMode(Tween.TweenProcessMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tween_process_mode");

        [GodotMethod("get_tween_process_mode")]
        [Obsolete("GetTweenProcessMode is deprecated. Use the PlaybackProcessMode property instead.")]
        public Tween.TweenProcessMode GetTweenProcessMode()
        {
            return (Tween.TweenProcessMode)NativeCalls.godot_icall_0_990(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "start");

        /// <summary>
        /// <para>Starts the tween. You can define animations both before and after this.</para>
        /// </summary>
        [GodotMethod("start")]
        public bool Start()
        {
            return NativeCalls.godot_icall_0_7(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reset");

        /// <summary>
        /// <para>Resets a tween to its initial value (the one given, not the one before the tween), given its object and property/method pair. By default, all tweens are reset, unless <c>key</c> is specified.</para>
        /// </summary>
        [GodotMethod("reset")]
        public bool Reset(Object @object, string key = "")
        {
            return NativeCalls.godot_icall_2_991(method_bind_9, Object.GetPtr(this), Object.GetPtr(@object), key);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reset_all");

        /// <summary>
        /// <para>Resets all tweens to their initial values (the ones given, not those before the tween).</para>
        /// </summary>
        [GodotMethod("reset_all")]
        public bool ResetAll()
        {
            return NativeCalls.godot_icall_0_7(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "stop");

        /// <summary>
        /// <para>Stops a tween, given its object and property/method pair. By default, all tweens are stopped, unless <c>key</c> is specified.</para>
        /// </summary>
        [GodotMethod("stop")]
        public bool Stop(Object @object, string key = "")
        {
            return NativeCalls.godot_icall_2_991(method_bind_11, Object.GetPtr(this), Object.GetPtr(@object), key);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "stop_all");

        /// <summary>
        /// <para>Stops animating all tweens.</para>
        /// </summary>
        [GodotMethod("stop_all")]
        public bool StopAll()
        {
            return NativeCalls.godot_icall_0_7(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "resume");

        /// <summary>
        /// <para>Continues animating a stopped tween, given its object and property/method pair. By default, all tweens are resumed, unless <c>key</c> is specified.</para>
        /// </summary>
        [GodotMethod("resume")]
        public bool Resume(Object @object, string key = "")
        {
            return NativeCalls.godot_icall_2_991(method_bind_13, Object.GetPtr(this), Object.GetPtr(@object), key);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "resume_all");

        /// <summary>
        /// <para>Continues animating all stopped tweens.</para>
        /// </summary>
        [GodotMethod("resume_all")]
        public bool ResumeAll()
        {
            return NativeCalls.godot_icall_0_7(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove");

        /// <summary>
        /// <para>Stops animation and removes a tween, given its object and property/method pair. By default, all tweens are removed, unless <c>key</c> is specified.</para>
        /// </summary>
        [GodotMethod("remove")]
        public bool Remove(Object @object, string key = "")
        {
            return NativeCalls.godot_icall_2_991(method_bind_15, Object.GetPtr(this), Object.GetPtr(@object), key);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_all");

        /// <summary>
        /// <para>Stops animation and removes all tweens.</para>
        /// </summary>
        [GodotMethod("remove_all")]
        public bool RemoveAll()
        {
            return NativeCalls.godot_icall_0_7(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "seek");

        /// <summary>
        /// <para>Sets the interpolation to the given <c>time</c> in seconds.</para>
        /// </summary>
        [GodotMethod("seek")]
        public bool Seek(float time)
        {
            return NativeCalls.godot_icall_1_593(method_bind_17, Object.GetPtr(this), time);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tell");

        /// <summary>
        /// <para>Returns the current time of the tween.</para>
        /// </summary>
        [GodotMethod("tell")]
        public float Tell()
        {
            return NativeCalls.godot_icall_0_14(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_runtime");

        /// <summary>
        /// <para>Returns the total time needed for all tweens to end. If you have two tweens, one lasting 10 seconds and the other 20 seconds, it would return 20 seconds, as by that time all tweens would have finished.</para>
        /// </summary>
        [GodotMethod("get_runtime")]
        public float GetRuntime()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "interpolate_property");

        /// <summary>
        /// <para>Animates <c>property</c> of <c>object</c> from <c>initial_val</c> to <c>final_val</c> for <c>duration</c> seconds, <c>delay</c> seconds later. Setting the initial value to <c>null</c> uses the current value of the property.</para>
        /// <para>Use <see cref="Godot.Tween.TransitionType"/> for <c>trans_type</c> and <see cref="Godot.Tween.EaseType"/> for <c>ease_type</c> parameters. These values control the timing and direction of the interpolation. See the class description for more information.</para>
        /// </summary>
        [GodotMethod("interpolate_property")]
        public bool InterpolateProperty(Object @object, NodePath property, object initialVal, object finalVal, float duration, Tween.TransitionType transType = (Tween.TransitionType)0, Tween.EaseType easeType = (Tween.EaseType)2, float delay = (float)0)
        {
            return NativeCalls.godot_icall_8_992(method_bind_20, Object.GetPtr(this), Object.GetPtr(@object), NodePath.GetPtr(property), initialVal, finalVal, duration, (int)transType, (int)easeType, delay);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "interpolate_method");

        /// <summary>
        /// <para>Animates <c>method</c> of <c>object</c> from <c>initial_val</c> to <c>final_val</c> for <c>duration</c> seconds, <c>delay</c> seconds later. Methods are called with consecutive values.</para>
        /// <para>Use <see cref="Godot.Tween.TransitionType"/> for <c>trans_type</c> and <see cref="Godot.Tween.EaseType"/> for <c>ease_type</c> parameters. These values control the timing and direction of the interpolation. See the class description for more information.</para>
        /// </summary>
        [GodotMethod("interpolate_method")]
        public bool InterpolateMethod(Object @object, string method, object initialVal, object finalVal, float duration, Tween.TransitionType transType = (Tween.TransitionType)0, Tween.EaseType easeType = (Tween.EaseType)2, float delay = (float)0)
        {
            return NativeCalls.godot_icall_8_993(method_bind_21, Object.GetPtr(this), Object.GetPtr(@object), method, initialVal, finalVal, duration, (int)transType, (int)easeType, delay);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "interpolate_callback");

        /// <summary>
        /// <para>Calls <c>callback</c> of <c>object</c> after <c>duration</c>. <c>arg1</c>-<c>arg5</c> are arguments to be passed to the callback.</para>
        /// </summary>
        [GodotMethod("interpolate_callback")]
        public bool InterpolateCallback(Object @object, float duration, string callback, object arg1 = null, object arg2 = null, object arg3 = null, object arg4 = null, object arg5 = null, object arg6 = null, object arg7 = null, object arg8 = null)
        {
            return NativeCalls.godot_icall_11_994(method_bind_22, Object.GetPtr(this), Object.GetPtr(@object), duration, callback, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "interpolate_deferred_callback");

        /// <summary>
        /// <para>Calls <c>callback</c> of <c>object</c> after <c>duration</c> on the main thread (similar to <see cref="Godot.Object.CallDeferred"/>). <c>arg1</c>-<c>arg5</c> are arguments to be passed to the callback.</para>
        /// </summary>
        [GodotMethod("interpolate_deferred_callback")]
        public bool InterpolateDeferredCallback(Object @object, float duration, string callback, object arg1 = null, object arg2 = null, object arg3 = null, object arg4 = null, object arg5 = null, object arg6 = null, object arg7 = null, object arg8 = null)
        {
            return NativeCalls.godot_icall_11_994(method_bind_23, Object.GetPtr(this), Object.GetPtr(@object), duration, callback, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "follow_property");

        /// <summary>
        /// <para>Follows <c>property</c> of <c>object</c> and applies it on <c>target_property</c> of <c>target</c>, beginning from <c>initial_val</c> for <c>duration</c> seconds, <c>delay</c> seconds later.</para>
        /// <para>Use <see cref="Godot.Tween.TransitionType"/> for <c>trans_type</c> and <see cref="Godot.Tween.EaseType"/> for <c>ease_type</c> parameters. These values control the timing and direction of the interpolation. See the class description for more information.</para>
        /// </summary>
        [GodotMethod("follow_property")]
        public bool FollowProperty(Object @object, NodePath property, object initialVal, Object target, NodePath targetProperty, float duration, Tween.TransitionType transType = (Tween.TransitionType)0, Tween.EaseType easeType = (Tween.EaseType)2, float delay = (float)0)
        {
            return NativeCalls.godot_icall_9_995(method_bind_24, Object.GetPtr(this), Object.GetPtr(@object), NodePath.GetPtr(property), initialVal, Object.GetPtr(target), NodePath.GetPtr(targetProperty), duration, (int)transType, (int)easeType, delay);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "follow_method");

        /// <summary>
        /// <para>Follows <c>method</c> of <c>object</c> and applies the returned value on <c>target_method</c> of <c>target</c>, beginning from <c>initial_val</c> for <c>duration</c> seconds, <c>delay</c> later. Methods are called with consecutive values.</para>
        /// <para>Use <see cref="Godot.Tween.TransitionType"/> for <c>trans_type</c> and <see cref="Godot.Tween.EaseType"/> for <c>ease_type</c> parameters. These values control the timing and direction of the interpolation. See the class description for more information.</para>
        /// </summary>
        [GodotMethod("follow_method")]
        public bool FollowMethod(Object @object, string method, object initialVal, Object target, string targetMethod, float duration, Tween.TransitionType transType = (Tween.TransitionType)0, Tween.EaseType easeType = (Tween.EaseType)2, float delay = (float)0)
        {
            return NativeCalls.godot_icall_9_996(method_bind_25, Object.GetPtr(this), Object.GetPtr(@object), method, initialVal, Object.GetPtr(target), targetMethod, duration, (int)transType, (int)easeType, delay);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "targeting_property");

        /// <summary>
        /// <para>Animates <c>property</c> of <c>object</c> from the current value of the <c>initial_val</c> property of <c>initial</c> to <c>final_val</c> for <c>duration</c> seconds, <c>delay</c> seconds later.</para>
        /// <para>Use <see cref="Godot.Tween.TransitionType"/> for <c>trans_type</c> and <see cref="Godot.Tween.EaseType"/> for <c>ease_type</c> parameters. These values control the timing and direction of the interpolation. See the class description for more information.</para>
        /// </summary>
        [GodotMethod("targeting_property")]
        public bool TargetingProperty(Object @object, NodePath property, Object initial, NodePath initialVal, object finalVal, float duration, Tween.TransitionType transType = (Tween.TransitionType)0, Tween.EaseType easeType = (Tween.EaseType)2, float delay = (float)0)
        {
            return NativeCalls.godot_icall_9_997(method_bind_26, Object.GetPtr(this), Object.GetPtr(@object), NodePath.GetPtr(property), Object.GetPtr(initial), NodePath.GetPtr(initialVal), finalVal, duration, (int)transType, (int)easeType, delay);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "targeting_method");

        /// <summary>
        /// <para>Animates <c>method</c> of <c>object</c> from the value returned by <c>initial_method</c> to <c>final_val</c> for <c>duration</c> seconds, <c>delay</c> seconds later. Methods are animated by calling them with consecutive values.</para>
        /// <para>Use <see cref="Godot.Tween.TransitionType"/> for <c>trans_type</c> and <see cref="Godot.Tween.EaseType"/> for <c>ease_type</c> parameters. These values control the timing and direction of the interpolation. See the class description for more information.</para>
        /// </summary>
        [GodotMethod("targeting_method")]
        public bool TargetingMethod(Object @object, string method, Object initial, string initialMethod, object finalVal, float duration, Tween.TransitionType transType = (Tween.TransitionType)0, Tween.EaseType easeType = (Tween.EaseType)2, float delay = (float)0)
        {
            return NativeCalls.godot_icall_9_998(method_bind_27, Object.GetPtr(this), Object.GetPtr(@object), method, Object.GetPtr(initial), initialMethod, finalVal, duration, (int)transType, (int)easeType, delay);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
