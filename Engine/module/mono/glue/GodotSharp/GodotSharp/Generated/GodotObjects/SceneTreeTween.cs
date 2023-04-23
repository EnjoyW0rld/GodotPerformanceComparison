using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.SceneTreeTween"/> is a tween managed by the scene tree. As opposed to <see cref="Godot.Tween"/>, it does not require the instantiation of a node.</para>
    /// <para><see cref="Godot.SceneTreeTween"/>s are more light-weight than <see cref="Godot.AnimationPlayer"/>, so they are very much suited for simple animations or general tasks that don't require visual tweaking provided by the editor. They can be used in a fire-and-forget manner for some logic that normally would be done by code. You can e.g. make something shoot periodically by using a looped <see cref="Godot.CallbackTweener"/> with a delay.</para>
    /// <para>A <see cref="Godot.SceneTreeTween"/> can be created by using either <see cref="Godot.SceneTree.CreateTween"/> or <see cref="Godot.Node.CreateTween"/>. <see cref="Godot.SceneTreeTween"/>s created manually (i.e. by using <c>Tween.new()</c>) are invalid. They can't be used for tweening values, but you can do manual interpolation with <see cref="Godot.SceneTreeTween.InterpolateValue"/>.</para>
    /// <para>A tween animation is created by adding <see cref="Godot.Tweener"/>s to the <see cref="Godot.SceneTreeTween"/> object, using <see cref="Godot.SceneTreeTween.TweenProperty"/>, <see cref="Godot.SceneTreeTween.TweenInterval"/>, <see cref="Godot.SceneTreeTween.TweenCallback"/> or <see cref="Godot.SceneTreeTween.TweenMethod"/>:</para>
    /// <para><code>
    /// var tween = get_tree().create_tween()
    /// tween.tween_property($Sprite, "modulate", Color.red, 1)
    /// tween.tween_property($Sprite, "scale", Vector2(), 1)
    /// tween.tween_callback($Sprite, "queue_free")
    /// </code></para>
    /// <para>This sequence will make the <c>$Sprite</c> node turn red, then shrink, before finally calling <see cref="Godot.Node.QueueFree"/> to free the sprite. <see cref="Godot.Tweener"/>s are executed one after another by default. This behavior can be changed using <see cref="Godot.SceneTreeTween.Parallel"/> and <see cref="Godot.SceneTreeTween.SetParallel"/>.</para>
    /// <para>When a <see cref="Godot.Tweener"/> is created with one of the <c>tween_*</c> methods, a chained method call can be used to tweak the properties of this <see cref="Godot.Tweener"/>. For example, if you want to set a different transition type in the above example, you can use <see cref="Godot.SceneTreeTween.SetTrans"/>:</para>
    /// <para><code>
    /// var tween = get_tree().create_tween()
    /// tween.tween_property($Sprite, "modulate", Color.red, 1).set_trans(Tween.TRANS_SINE)
    /// tween.tween_property($Sprite, "scale", Vector2(), 1).set_trans(Tween.TRANS_BOUNCE)
    /// tween.tween_callback($Sprite, "queue_free")
    /// </code></para>
    /// <para>Most of the <see cref="Godot.SceneTreeTween"/> methods can be chained this way too. In the following example the <see cref="Godot.SceneTreeTween"/> is bound to the running script's node and a default transition is set for its <see cref="Godot.Tweener"/>s:</para>
    /// <para><code>
    /// var tween = get_tree().create_tween().bind_node(self).set_trans(Tween.TRANS_ELASTIC)
    /// tween.tween_property($Sprite, "modulate", Color.red, 1)
    /// tween.tween_property($Sprite, "scale", Vector2(), 1)
    /// tween.tween_callback($Sprite, "queue_free")
    /// </code></para>
    /// <para>Another interesting use for <see cref="Godot.SceneTreeTween"/>s is animating arbitrary sets of objects:</para>
    /// <para><code>
    /// var tween = create_tween()
    /// for sprite in get_children():
    ///     tween.tween_property(sprite, "position", Vector2(0, 0), 1)
    /// </code></para>
    /// <para>In the example above, all children of a node are moved one after another to position (0, 0).</para>
    /// <para>You should avoid using more than one <see cref="Godot.SceneTreeTween"/> per object's property. If two or more tweens animate one property at the same time, the last one created will take priority and assign the final value. If you want to interrupt and restart an animation, consider assigning the <see cref="Godot.SceneTreeTween"/> to a variable:</para>
    /// <para><code>
    /// var tween
    /// func animate():
    ///     if tween:
    ///         tween.kill() # Abort the previous animation.
    ///     tween = create_tween()
    /// </code></para>
    /// <para>Some <see cref="Godot.Tweener"/>s use transitions and eases. The first accepts a <see cref="Godot.Tween.TransitionType"/> constant, and refers to the way the timing of the animation is handled (see <a href="https://easings.net/">easings.net</a> for some examples). The second accepts an <see cref="Godot.Tween.EaseType"/> constant, and controls where the <c>trans_type</c> is applied to the interpolation (in the beginning, the end, or both). If you don't know which transition and easing to pick, you can try different <see cref="Godot.Tween.TransitionType"/> constants with <see cref="Godot.Tween.EaseType.InOut"/>, and use the one that looks best.</para>
    /// <para><a href="https://raw.githubusercontent.com/godotengine/godot-docs/master/img/tween_cheatsheet.png">Tween easing and transition types cheatsheet</a></para>
    /// <para>Note: All <see cref="Godot.SceneTreeTween"/>s will automatically start by default. To prevent a <see cref="Godot.SceneTreeTween"/> from autostarting, you can call <see cref="Godot.SceneTreeTween.Stop"/> immediately after it is created.</para>
    /// <para>Note: <see cref="Godot.SceneTreeTween"/>s are processing after all of nodes in the current frame, i.e. after <see cref="Godot.Node._Process"/> or <see cref="Godot.Node._PhysicsProcess"/> (depending on <see cref="Godot.Tween.TweenProcessMode"/>).</para>
    /// </summary>
    public partial class SceneTreeTween : Reference
    {
        public enum TweenPauseMode
        {
            /// <summary>
            /// <para>If the <see cref="Godot.SceneTreeTween"/> has a bound node, it will process when that node can process (see <see cref="Godot.Node.PauseMode"/>). Otherwise it's the same as <see cref="Godot.SceneTreeTween.TweenPauseMode.Stop"/>.</para>
            /// </summary>
            Bound = 0,
            /// <summary>
            /// <para>If <see cref="Godot.SceneTree"/> is paused, the <see cref="Godot.SceneTreeTween"/> will also pause.</para>
            /// </summary>
            Stop = 1,
            /// <summary>
            /// <para>The <see cref="Godot.SceneTreeTween"/> will process regardless of whether <see cref="Godot.SceneTree"/> is paused.</para>
            /// </summary>
            Process = 2
        }

        private const string nativeName = "SceneTreeTween";

        public SceneTreeTween() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SceneTreeTween_Ctor(this);
        }

        internal SceneTreeTween(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tween_property");

        /// <summary>
        /// <para>Creates and appends a <see cref="Godot.PropertyTweener"/>. This method tweens a <c>property</c> of an <c>object</c> between an initial value and <c>final_val</c> in a span of time equal to <c>duration</c>, in seconds. The initial value by default is the property's value at the time the tweening of the <see cref="Godot.PropertyTweener"/> starts. For example:</para>
        /// <para><code>
        /// var tween = create_tween()
        /// tween.tween_property($Sprite, "position", Vector2(100, 200), 1)
        /// tween.tween_property($Sprite, "position", Vector2(200, 300), 1)
        /// </code></para>
        /// <para>will move the sprite to position (100, 200) and then to (200, 300). If you use <see cref="Godot.PropertyTweener.From"/> or <see cref="Godot.PropertyTweener.FromCurrent"/>, the starting position will be overwritten by the given value instead. See other methods in <see cref="Godot.PropertyTweener"/> to see how the tweening can be tweaked further.</para>
        /// <para>Note: You can find the correct property name by hovering over the property in the Inspector. You can also provide the components of a property directly by using <c>"property:component"</c> (eg. <c>position:x</c>), where it would only apply to that particular component.</para>
        /// <para>Example: moving object twice from the same position, with different transition types.</para>
        /// <para><code>
        /// var tween = create_tween()
        /// tween.tween_property($Sprite, "position", Vector2.RIGHT * 300, 1).as_relative().set_trans(Tween.TRANS_SINE)
        /// tween.tween_property($Sprite, "position", Vector2.RIGHT * 300, 1).as_relative().from_current().set_trans(Tween.TRANS_EXPO)
        /// </code></para>
        /// </summary>
        [GodotMethod("tween_property")]
        public PropertyTweener TweenProperty(Object @object, NodePath property, object finalVal, float duration)
        {
            return NativeCalls.godot_icall_4_839(method_bind_0, Object.GetPtr(this), Object.GetPtr(@object), NodePath.GetPtr(property), finalVal, duration);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tween_interval");

        /// <summary>
        /// <para>Creates and appends an <see cref="Godot.IntervalTweener"/>. This method can be used to create delays in the tween animation, as an alternative to using the delay in other <see cref="Godot.Tweener"/>s, or when there's no animation (in which case the <see cref="Godot.SceneTreeTween"/> acts as a timer). <c>time</c> is the length of the interval, in seconds.</para>
        /// <para>Example: creating an interval in code execution.</para>
        /// <para><code>
        /// # ... some code
        /// yield(create_tween().tween_interval(2), "finished")
        /// # ... more code
        /// </code></para>
        /// <para>Example: creating an object that moves back and forth and jumps every few seconds.</para>
        /// <para><code>
        /// var tween = create_tween().set_loops()
        /// tween.tween_property($Sprite, "position:x", 200.0, 1).as_relative()
        /// tween.tween_callback(self, "jump")
        /// tween.tween_interval(2)
        /// tween.tween_property($Sprite, "position:x", -200.0, 1).as_relative()
        /// tween.tween_callback(self, "jump")
        /// tween.tween_interval(2)
        /// </code></para>
        /// </summary>
        [GodotMethod("tween_interval")]
        public IntervalTweener TweenInterval(float time)
        {
            return NativeCalls.godot_icall_1_840(method_bind_1, Object.GetPtr(this), time);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tween_callback");

        /// <summary>
        /// <para>Creates and appends a <see cref="Godot.CallbackTweener"/>. This method can be used to call an arbitrary method in any object. Use <c>binds</c> to bind additional arguments for the call.</para>
        /// <para>Example: object that keeps shooting every 1 second.</para>
        /// <para><code>
        /// var tween = get_tree().create_tween().set_loops()
        /// tween.tween_callback(self, "shoot").set_delay(1)
        /// </code></para>
        /// <para>Example: turning a sprite red and then blue, with 2 second delay.</para>
        /// <para><code>
        /// var tween = get_tree().create_tween()
        /// tween.tween_callback($Sprite, "set_modulate", [Color.red]).set_delay(2)
        /// tween.tween_callback($Sprite, "set_modulate", [Color.blue]).set_delay(2)
        /// </code></para>
        /// </summary>
        /// <param name="binds">If the parameter is null, then the default value is new Godot.Collections.Array { }</param>
        [GodotMethod("tween_callback")]
        public CallbackTweener TweenCallback(Object @object, string method, Godot.Collections.Array binds = null)
        {
            Godot.Collections.Array binds_in = binds != null ? binds : new Godot.Collections.Array { };
            return NativeCalls.godot_icall_3_841(method_bind_2, Object.GetPtr(this), Object.GetPtr(@object), method, binds_in.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tween_method");

        /// <summary>
        /// <para>Creates and appends a <see cref="Godot.MethodTweener"/>. This method is similar to a combination of <see cref="Godot.SceneTreeTween.TweenCallback"/> and <see cref="Godot.SceneTreeTween.TweenProperty"/>. It calls a method over time with a tweened value provided as an argument. The value is tweened between <c>from</c> and <c>to</c> over the time specified by <c>duration</c>, in seconds. Use <c>binds</c> to bind additional arguments for the call. You can use <see cref="Godot.MethodTweener.SetEase"/> and <see cref="Godot.MethodTweener.SetTrans"/> to tweak the easing and transition of the value or <see cref="Godot.MethodTweener.SetDelay"/> to delay the tweening.</para>
        /// <para>Example: making a 3D object look from one point to another point.</para>
        /// <para><code>
        /// var tween = create_tween()
        /// tween.tween_method(self, "look_at", Vector3(-1, 0, -1), Vector3(1, 0, -1), 1, [Vector3.UP]) # The look_at() method takes up vector as second argument.
        /// </code></para>
        /// <para>Example: setting a text of a <see cref="Godot.Label"/>, using an intermediate method and after a delay.</para>
        /// <para><code>
        /// func _ready():
        ///     var tween = create_tween()
        ///     tween.tween_method(self, "set_label_text", 0, 10, 1).set_delay(1)
        /// 
        /// func set_label_text(value: int):
        ///     $Label.text = "Counting " + str(value)
        /// </code></para>
        /// </summary>
        /// <param name="binds">If the parameter is null, then the default value is new Godot.Collections.Array { }</param>
        [GodotMethod("tween_method")]
        public MethodTweener TweenMethod(Object @object, string method, object from, object to, float duration, Godot.Collections.Array binds = null)
        {
            Godot.Collections.Array binds_in = binds != null ? binds : new Godot.Collections.Array { };
            return NativeCalls.godot_icall_6_842(method_bind_3, Object.GetPtr(this), Object.GetPtr(@object), method, from, to, duration, binds_in.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "custom_step");

        /// <summary>
        /// <para>Processes the <see cref="Godot.SceneTreeTween"/> by the given <c>delta</c> value, in seconds. This is mostly useful for manual control when the <see cref="Godot.SceneTreeTween"/> is paused. It can also be used to end the <see cref="Godot.SceneTreeTween"/> animation immediately, by setting <c>delta</c> longer than the whole duration of the <see cref="Godot.SceneTreeTween"/> animation.</para>
        /// <para>Returns <c>true</c> if the <see cref="Godot.SceneTreeTween"/> still has <see cref="Godot.Tweener"/>s that haven't finished.</para>
        /// <para>Note: The <see cref="Godot.SceneTreeTween"/> will become invalid in the next processing frame after its animation finishes. Calling <see cref="Godot.SceneTreeTween.Stop"/> after performing <see cref="Godot.SceneTreeTween.CustomStep"/> instead keeps and resets the <see cref="Godot.SceneTreeTween"/>.</para>
        /// </summary>
        [GodotMethod("custom_step")]
        public bool CustomStep(float delta)
        {
            return NativeCalls.godot_icall_1_593(method_bind_4, Object.GetPtr(this), delta);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "stop");

        /// <summary>
        /// <para>Stops the tweening and resets the <see cref="Godot.SceneTreeTween"/> to its initial state. This will not remove any appended <see cref="Godot.Tweener"/>s.</para>
        /// </summary>
        [GodotMethod("stop")]
        public void Stop()
        {
            NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "pause");

        /// <summary>
        /// <para>Pauses the tweening. The animation can be resumed by using <see cref="Godot.SceneTreeTween.Play"/>.</para>
        /// </summary>
        [GodotMethod("pause")]
        public void Pause()
        {
            NativeCalls.godot_icall_0_3(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "play");

        /// <summary>
        /// <para>Resumes a paused or stopped <see cref="Godot.SceneTreeTween"/>.</para>
        /// </summary>
        [GodotMethod("play")]
        public void Play()
        {
            NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "kill");

        /// <summary>
        /// <para>Aborts all tweening operations and invalidates the <see cref="Godot.SceneTreeTween"/>.</para>
        /// </summary>
        [GodotMethod("kill")]
        public void Kill()
        {
            NativeCalls.godot_icall_0_3(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_total_elapsed_time");

        /// <summary>
        /// <para>Returns the total time in seconds the <see cref="Godot.SceneTreeTween"/> has been animating (i.e. the time since it started, not counting pauses etc.). The time is affected by <see cref="Godot.SceneTreeTween.SetSpeedScale"/>, and <see cref="Godot.SceneTreeTween.Stop"/> will reset it to <c>0</c>.</para>
        /// <para>Note: As it results from accumulating frame deltas, the time returned after the <see cref="Godot.SceneTreeTween"/> has finished animating will be slightly greater than the actual <see cref="Godot.SceneTreeTween"/> duration.</para>
        /// </summary>
        [GodotMethod("get_total_elapsed_time")]
        public float GetTotalElapsedTime()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_running");

        /// <summary>
        /// <para>Returns whether the <see cref="Godot.SceneTreeTween"/> is currently running, i.e. it wasn't paused and it's not finished.</para>
        /// </summary>
        [GodotMethod("is_running")]
        public bool IsRunning()
        {
            return NativeCalls.godot_icall_0_7(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_valid");

        /// <summary>
        /// <para>Returns whether the <see cref="Godot.SceneTreeTween"/> is valid. A valid <see cref="Godot.SceneTreeTween"/> is a <see cref="Godot.SceneTreeTween"/> contained by the scene tree (i.e. the array from <see cref="Godot.SceneTree.GetProcessedTweens"/> will contain this <see cref="Godot.SceneTreeTween"/>). A <see cref="Godot.SceneTreeTween"/> might become invalid when it has finished tweening, is killed, or when created with <c>SceneTreeTween.new()</c>. Invalid <see cref="Godot.SceneTreeTween"/>s can't have <see cref="Godot.Tweener"/>s appended. You can however still use <see cref="Godot.SceneTreeTween.InterpolateValue"/>.</para>
        /// </summary>
        [GodotMethod("is_valid")]
        public bool IsValid()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "bind_node");

        /// <summary>
        /// <para>Binds this <see cref="Godot.SceneTreeTween"/> with the given <c>node</c>. <see cref="Godot.SceneTreeTween"/>s are processed directly by the <see cref="Godot.SceneTree"/>, so they run independently of the animated nodes. When you bind a <see cref="Godot.Node"/> with the <see cref="Godot.SceneTreeTween"/>, the <see cref="Godot.SceneTreeTween"/> will halt the animation when the object is not inside tree and the <see cref="Godot.SceneTreeTween"/> will be automatically killed when the bound object is freed. Also <see cref="Godot.SceneTreeTween.TweenPauseMode.Bound"/> will make the pausing behavior dependent on the bound node.</para>
        /// <para>For a shorter way to create and bind a <see cref="Godot.SceneTreeTween"/>, you can use <see cref="Godot.Node.CreateTween"/>.</para>
        /// </summary>
        [GodotMethod("bind_node")]
        public SceneTreeTween BindNode(Node node)
        {
            return NativeCalls.godot_icall_1_843(method_bind_12, Object.GetPtr(this), Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_process_mode");

        /// <summary>
        /// <para>Determines whether the <see cref="Godot.SceneTreeTween"/> should run during idle frame (see <see cref="Godot.Node._Process"/>) or physics frame (see <see cref="Godot.Node._PhysicsProcess"/>.</para>
        /// <para>Default value is <see cref="Godot.Tween.TweenProcessMode.Idle"/>.</para>
        /// </summary>
        [GodotMethod("set_process_mode")]
        public SceneTreeTween SetProcessMode(Tween.TweenProcessMode mode)
        {
            return NativeCalls.godot_icall_1_844(method_bind_13, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pause_mode");

        /// <summary>
        /// <para>Determines the behavior of the <see cref="Godot.SceneTreeTween"/> when the <see cref="Godot.SceneTree"/> is paused. Check <see cref="Godot.SceneTreeTween.TweenPauseMode"/> for options.</para>
        /// <para>Default value is <see cref="Godot.SceneTreeTween.TweenPauseMode.Bound"/>.</para>
        /// </summary>
        [GodotMethod("set_pause_mode")]
        public SceneTreeTween SetPauseMode(SceneTreeTween.TweenPauseMode mode)
        {
            return NativeCalls.godot_icall_1_844(method_bind_14, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_parallel");

        /// <summary>
        /// <para>If <c>parallel</c> is <c>true</c>, the <see cref="Godot.Tweener"/>s appended after this method will by default run simultaneously, as opposed to sequentially.</para>
        /// </summary>
        [GodotMethod("set_parallel")]
        public SceneTreeTween SetParallel(bool parallel = true)
        {
            return NativeCalls.godot_icall_1_845(method_bind_15, Object.GetPtr(this), parallel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_loops");

        /// <summary>
        /// <para>Sets the number of times the tweening sequence will be repeated, i.e. <c>set_loops(2)</c> will run the animation twice.</para>
        /// <para>Calling this method without arguments will make the <see cref="Godot.SceneTreeTween"/> run infinitely, until either it is killed with <see cref="Godot.SceneTreeTween.Kill"/>, the <see cref="Godot.SceneTreeTween"/>'s bound node is freed, or all the animated objects have been freed (which makes further animation impossible).</para>
        /// <para>Warning: Make sure to always add some duration/delay when using infinite loops. To prevent the game freezing, 0-duration looped animations (e.g. a single <see cref="Godot.CallbackTweener"/> with no delay) are stopped after a small number of loops, which may produce unexpected results. If a <see cref="Godot.SceneTreeTween"/>'s lifetime depends on some node, always use <see cref="Godot.SceneTreeTween.BindNode"/>.</para>
        /// </summary>
        [GodotMethod("set_loops")]
        public SceneTreeTween SetLoops(int loops = 0)
        {
            return NativeCalls.godot_icall_1_844(method_bind_16, Object.GetPtr(this), loops);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_speed_scale");

        /// <summary>
        /// <para>Scales the speed of tweening. This affects all <see cref="Godot.Tweener"/>s and their delays.</para>
        /// </summary>
        [GodotMethod("set_speed_scale")]
        public SceneTreeTween SetSpeedScale(float speed)
        {
            return NativeCalls.godot_icall_1_846(method_bind_17, Object.GetPtr(this), speed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_trans");

        /// <summary>
        /// <para>Sets the default transition type for <see cref="Godot.PropertyTweener"/>s and <see cref="Godot.MethodTweener"/>s animated by this <see cref="Godot.SceneTreeTween"/>.</para>
        /// </summary>
        [GodotMethod("set_trans")]
        public SceneTreeTween SetTrans(Tween.TransitionType trans)
        {
            return NativeCalls.godot_icall_1_844(method_bind_18, Object.GetPtr(this), (int)trans);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ease");

        /// <summary>
        /// <para>Sets the default ease type for <see cref="Godot.PropertyTweener"/>s and <see cref="Godot.MethodTweener"/>s animated by this <see cref="Godot.SceneTreeTween"/>.</para>
        /// </summary>
        [GodotMethod("set_ease")]
        public SceneTreeTween SetEase(Tween.EaseType ease)
        {
            return NativeCalls.godot_icall_1_844(method_bind_19, Object.GetPtr(this), (int)ease);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "parallel");

        /// <summary>
        /// <para>Makes the next <see cref="Godot.Tweener"/> run parallelly to the previous one. Example:</para>
        /// <para><code>
        /// var tween = create_tween()
        /// tween.tween_property(...)
        /// tween.parallel().tween_property(...)
        /// tween.parallel().tween_property(...)
        /// </code></para>
        /// <para>All <see cref="Godot.Tweener"/>s in the example will run at the same time.</para>
        /// <para>You can make the <see cref="Godot.SceneTreeTween"/> parallel by default by using <see cref="Godot.SceneTreeTween.SetParallel"/>.</para>
        /// </summary>
        [GodotMethod("parallel")]
        public SceneTreeTween Parallel()
        {
            return NativeCalls.godot_icall_0_683(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "chain");

        /// <summary>
        /// <para>Used to chain two <see cref="Godot.Tweener"/>s after <see cref="Godot.SceneTreeTween.SetParallel"/> is called with <c>true</c>.</para>
        /// <para><code>
        /// var tween = create_tween().set_parallel(true)
        /// tween.tween_property(...)
        /// tween.tween_property(...) # Will run parallelly with above.
        /// tween.chain().tween_property(...) # Will run after two above are finished.
        /// </code></para>
        /// </summary>
        [GodotMethod("chain")]
        public SceneTreeTween Chain()
        {
            return NativeCalls.godot_icall_0_683(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "interpolate_value");

        /// <summary>
        /// <para>This method can be used for manual interpolation of a value, when you don't want <see cref="Godot.SceneTreeTween"/> to do animating for you. It's similar to <c>@GDScript.lerp</c>, but with support for custom transition and easing.</para>
        /// <para><c>initial_value</c> is the starting value of the interpolation.</para>
        /// <para><c>delta_value</c> is the change of the value in the interpolation, i.e. it's equal to <c>final_value - initial_value</c>.</para>
        /// <para><c>elapsed_time</c> is the time in seconds that passed after the interpolation started and it's used to control the position of the interpolation. E.g. when it's equal to half of the <c>duration</c>, the interpolated value will be halfway between initial and final values. This value can also be greater than <c>duration</c> or lower than 0, which will extrapolate the value.</para>
        /// <para><c>duration</c> is the total time of the interpolation.</para>
        /// <para>Note: If <c>duration</c> is equal to <c>0</c>, the method will always return the final value, regardless of <c>elapsed_time</c> provided.</para>
        /// </summary>
        [GodotMethod("interpolate_value")]
        public object InterpolateValue(object initialValue, object deltaValue, float elapsedTime, float duration, Tween.TransitionType transType, Tween.EaseType easeType)
        {
            return NativeCalls.godot_icall_6_847(method_bind_22, Object.GetPtr(this), initialValue, deltaValue, elapsedTime, duration, (int)transType, (int)easeType);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
