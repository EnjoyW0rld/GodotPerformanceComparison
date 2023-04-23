using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>An animation player is used for general-purpose playback of <see cref="Godot.Animation"/> resources. It contains a dictionary of animations (referenced by name) and custom blend times between their transitions. Additionally, animations can be played and blended in different channels.</para>
    /// <para><see cref="Godot.AnimationPlayer"/> is more suited than <see cref="Godot.Tween"/> for animations where you know the final values in advance. For example, fading a screen in and out is more easily done with an <see cref="Godot.AnimationPlayer"/> node thanks to the animation tools provided by the editor. That particular example can also be implemented with a <see cref="Godot.Tween"/> node, but it requires doing everything by code.</para>
    /// <para>Updating the target properties of animations occurs at process time.</para>
    /// </summary>
    public partial class AnimationPlayer : Node
    {
        public enum AnimationProcessMode
        {
            /// <summary>
            /// <para>Process animation during the physics process. This is especially useful when animating physics bodies.</para>
            /// </summary>
            Physics = 0,
            /// <summary>
            /// <para>Process animation during the idle process.</para>
            /// </summary>
            Idle = 1,
            /// <summary>
            /// <para>Do not process animation. Use <see cref="Godot.AnimationPlayer.Advance"/> to process the animation manually.</para>
            /// </summary>
            Manual = 2
        }

        public enum AnimationMethodCallMode
        {
            /// <summary>
            /// <para>Batch method calls during the animation process, then do the calls after events are processed. This avoids bugs involving deleting nodes or modifying the AnimationPlayer while playing.</para>
            /// </summary>
            Deferred = 0,
            /// <summary>
            /// <para>Make method calls immediately when reached in the animation.</para>
            /// </summary>
            Immediate = 1
        }

        /// <summary>
        /// <para>The node from which node path references will travel.</para>
        /// </summary>
        public NodePath RootNode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRoot();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRoot(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The name of the currently playing animation. If no animation is playing, the property's value is an empty string. Changing this value does not restart the animation. See <see cref="Godot.AnimationPlayer.Play"/> for more information on playing animations.</para>
        /// <para>Note: While this property appears in the inspector, it's not meant to be edited, and it's not saved in the scene. This property is mainly used to get the currently playing animation, and internally for animation playback tracks. For more information, see <see cref="Godot.Animation"/>.</para>
        /// </summary>
        public string CurrentAnimation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCurrentAnimation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCurrentAnimation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If playing, the current animation; otherwise, the animation last played. When set, would change the animation, but would not play it unless currently playing. See also <see cref="Godot.AnimationPlayer.CurrentAnimation"/>.</para>
        /// </summary>
        public string AssignedAnimation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAssignedAnimation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAssignedAnimation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The name of the animation to play when the scene loads.</para>
        /// </summary>
        public string Autoplay
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAutoplay();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAutoplay(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>This is used by the editor. If set to <c>true</c>, the scene will be saved with the effects of the reset animation applied (as if it had been seeked to time 0), then reverted after saving.</para>
        /// <para>In other words, the saved scene file will contain the "default pose", as defined by the reset animation, if any, with the editor keeping the values that the nodes had before saving.</para>
        /// </summary>
        public bool ResetOnSave
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsResetOnSaveEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetResetOnSaveEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The length (in seconds) of the currently being played animation.</para>
        /// </summary>
        public float CurrentAnimationLength
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCurrentAnimationLength();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The position (in seconds) of the currently playing animation.</para>
        /// </summary>
        public float CurrentAnimationPosition
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCurrentAnimationPosition();
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The process notification in which to update animations.</para>
        /// </summary>
        public AnimationPlayer.AnimationProcessMode PlaybackProcessMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAnimationProcessMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAnimationProcessMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The default time in which to blend animations. Ranges from 0 to 4096 with 0.01 precision.</para>
        /// </summary>
        public float PlaybackDefaultBlendTime
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDefaultBlendTime();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDefaultBlendTime(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, updates animations in response to process-related notifications.</para>
        /// </summary>
        public bool PlaybackActive
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsActive();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetActive(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The speed scaling ratio. For instance, if this value is 1, then the animation plays at normal speed. If it's 0.5, then it plays at half speed. If it's 2, then it plays at double speed.</para>
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

        /// <summary>
        /// <para>The call mode to use for Call Method tracks.</para>
        /// </summary>
        public AnimationPlayer.AnimationMethodCallMode MethodCallMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMethodCallMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMethodCallMode(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AnimationPlayer";

        public AnimationPlayer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimationPlayer_Ctor(this);
        }

        internal AnimationPlayer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_animation");

        /// <summary>
        /// <para>Adds <c>animation</c> to the player accessible with the key <c>name</c>.</para>
        /// </summary>
        [GodotMethod("add_animation")]
        public Error AddAnimation(string name, Animation animation)
        {
            return (Error)NativeCalls.godot_icall_2_122(method_bind_0, Object.GetPtr(this), name, Object.GetPtr(animation));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_animation");

        /// <summary>
        /// <para>Removes the animation with key <c>name</c>.</para>
        /// </summary>
        [GodotMethod("remove_animation")]
        public void RemoveAnimation(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_1, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rename_animation");

        /// <summary>
        /// <para>Renames an existing animation with key <c>name</c> to <c>newname</c>.</para>
        /// </summary>
        [GodotMethod("rename_animation")]
        public void RenameAnimation(string name, string newname)
        {
            NativeCalls.godot_icall_2_107(method_bind_2, Object.GetPtr(this), name, newname);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_animation");

        /// <summary>
        /// <para>Returns <c>true</c> if the <see cref="Godot.AnimationPlayer"/> stores an <see cref="Godot.Animation"/> with key <c>name</c>.</para>
        /// </summary>
        [GodotMethod("has_animation")]
        public bool HasAnimation(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_3, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_animation");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Animation"/> with the key <c>name</c>. If the animation does not exist, <c>null</c> is returned and an error is logged.</para>
        /// </summary>
        [GodotMethod("get_animation")]
        public Animation GetAnimation(string name)
        {
            return NativeCalls.godot_icall_1_123(method_bind_4, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_animation_list");

        /// <summary>
        /// <para>Returns the list of stored animation names.</para>
        /// </summary>
        [GodotMethod("get_animation_list")]
        public string[] GetAnimationList()
        {
            return NativeCalls.godot_icall_0_119(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "animation_set_next");

        /// <summary>
        /// <para>Triggers the <c>anim_to</c> animation when the <c>anim_from</c> animation completes.</para>
        /// </summary>
        [GodotMethod("animation_set_next")]
        public void AnimationSetNext(string animFrom, string animTo)
        {
            NativeCalls.godot_icall_2_107(method_bind_6, Object.GetPtr(this), animFrom, animTo);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "animation_get_next");

        /// <summary>
        /// <para>Returns the name of the next animation in the queue.</para>
        /// </summary>
        [GodotMethod("animation_get_next")]
        public string AnimationGetNext(string animFrom)
        {
            return NativeCalls.godot_icall_1_124(method_bind_7, Object.GetPtr(this), animFrom);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_blend_time");

        /// <summary>
        /// <para>Specifies a blend time (in seconds) between two animations, referenced by their names.</para>
        /// </summary>
        [GodotMethod("set_blend_time")]
        public void SetBlendTime(string animFrom, string animTo, float sec)
        {
            NativeCalls.godot_icall_3_125(method_bind_8, Object.GetPtr(this), animFrom, animTo, sec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_blend_time");

        /// <summary>
        /// <para>Gets the blend time (in seconds) between two animations, referenced by their names.</para>
        /// </summary>
        [GodotMethod("get_blend_time")]
        public float GetBlendTime(string animFrom, string animTo)
        {
            return NativeCalls.godot_icall_2_126(method_bind_9, Object.GetPtr(this), animFrom, animTo);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_blend_time");

        [GodotMethod("set_default_blend_time")]
        [Obsolete("SetDefaultBlendTime is deprecated. Use the PlaybackDefaultBlendTime property instead.")]
        public void SetDefaultBlendTime(float sec)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), sec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_default_blend_time");

        [GodotMethod("get_default_blend_time")]
        [Obsolete("GetDefaultBlendTime is deprecated. Use the PlaybackDefaultBlendTime property instead.")]
        public float GetDefaultBlendTime()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "play");

        /// <summary>
        /// <para>Plays the animation with key <c>name</c>. Custom blend times and speed can be set. If <c>custom_speed</c> is negative and <c>from_end</c> is <c>true</c>, the animation will play backwards (which is equivalent to calling <see cref="Godot.AnimationPlayer.PlayBackwards"/>).</para>
        /// <para>The <see cref="Godot.AnimationPlayer"/> keeps track of its current or last played animation with <see cref="Godot.AnimationPlayer.AssignedAnimation"/>. If this method is called with that same animation <c>name</c>, or with no <c>name</c> parameter, the assigned animation will resume playing if it was paused, or restart if it was stopped (see <see cref="Godot.AnimationPlayer.Stop"/> for both pause and stop). If the animation was already playing, it will keep playing.</para>
        /// <para>Note: The animation will be updated the next time the <see cref="Godot.AnimationPlayer"/> is processed. If other variables are updated at the same time this is called, they may be updated too early. To perform the update immediately, call <c>advance(0)</c>.</para>
        /// </summary>
        [GodotMethod("play")]
        public void Play(string name = "", float customBlend = (float)-1, float customSpeed = 1f, bool fromEnd = false)
        {
            NativeCalls.godot_icall_4_127(method_bind_12, Object.GetPtr(this), name, customBlend, customSpeed, fromEnd);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "play_backwards");

        /// <summary>
        /// <para>Plays the animation with key <c>name</c> in reverse.</para>
        /// <para>This method is a shorthand for <see cref="Godot.AnimationPlayer.Play"/> with <c>custom_speed = -1.0</c> and <c>from_end = true</c>, so see its description for more information.</para>
        /// </summary>
        [GodotMethod("play_backwards")]
        public void PlayBackwards(string name = "", float customBlend = (float)-1)
        {
            NativeCalls.godot_icall_2_128(method_bind_13, Object.GetPtr(this), name, customBlend);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "stop");

        /// <summary>
        /// <para>Stops or pauses the currently playing animation. If <c>reset</c> is <c>true</c>, the animation position is reset to <c>0</c> and the playback speed is reset to <c>1.0</c>.</para>
        /// <para>If <c>reset</c> is <c>false</c>, the <see cref="Godot.AnimationPlayer.CurrentAnimationPosition"/> will be kept and calling <see cref="Godot.AnimationPlayer.Play"/> or <see cref="Godot.AnimationPlayer.PlayBackwards"/> without arguments or with the same animation name as <see cref="Godot.AnimationPlayer.AssignedAnimation"/> will resume the animation.</para>
        /// </summary>
        [GodotMethod("stop")]
        public void Stop(bool reset = true)
        {
            NativeCalls.godot_icall_1_16(method_bind_14, Object.GetPtr(this), reset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_playing");

        /// <summary>
        /// <para>Returns <c>true</c> if playing an animation.</para>
        /// </summary>
        [GodotMethod("is_playing")]
        public bool IsPlaying()
        {
            return NativeCalls.godot_icall_0_7(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_current_animation");

        [GodotMethod("set_current_animation")]
        [Obsolete("SetCurrentAnimation is deprecated. Use the CurrentAnimation property instead.")]
        public void SetCurrentAnimation(string anim)
        {
            NativeCalls.godot_icall_1_54(method_bind_16, Object.GetPtr(this), anim);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_animation");

        [GodotMethod("get_current_animation")]
        [Obsolete("GetCurrentAnimation is deprecated. Use the CurrentAnimation property instead.")]
        public string GetCurrentAnimation()
        {
            return NativeCalls.godot_icall_0_6(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_assigned_animation");

        [GodotMethod("set_assigned_animation")]
        [Obsolete("SetAssignedAnimation is deprecated. Use the AssignedAnimation property instead.")]
        public void SetAssignedAnimation(string anim)
        {
            NativeCalls.godot_icall_1_54(method_bind_18, Object.GetPtr(this), anim);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_assigned_animation");

        [GodotMethod("get_assigned_animation")]
        [Obsolete("GetAssignedAnimation is deprecated. Use the AssignedAnimation property instead.")]
        public string GetAssignedAnimation()
        {
            return NativeCalls.godot_icall_0_6(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "queue");

        /// <summary>
        /// <para>Queues an animation for playback once the current one is done.</para>
        /// <para>Note: If a looped animation is currently playing, the queued animation will never play unless the looped animation is stopped somehow.</para>
        /// </summary>
        [GodotMethod("queue")]
        public void Queue(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_20, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_queue");

        /// <summary>
        /// <para>Returns a list of the animation names that are currently queued to play.</para>
        /// </summary>
        [GodotMethod("get_queue")]
        public string[] GetQueue()
        {
            return NativeCalls.godot_icall_0_119(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_queue");

        /// <summary>
        /// <para>Clears all queued, unplayed animations.</para>
        /// </summary>
        [GodotMethod("clear_queue")]
        public void ClearQueue()
        {
            NativeCalls.godot_icall_0_3(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_active");

        [GodotMethod("set_active")]
        [Obsolete("SetActive is deprecated. Use the PlaybackActive property instead.")]
        public void SetActive(bool active)
        {
            NativeCalls.godot_icall_1_16(method_bind_23, Object.GetPtr(this), active);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_active");

        [GodotMethod("is_active")]
        [Obsolete("IsActive is deprecated. Use the PlaybackActive property instead.")]
        public bool IsActive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_speed_scale");

        [GodotMethod("set_speed_scale")]
        [Obsolete("SetSpeedScale is deprecated. Use the PlaybackSpeed property instead.")]
        public void SetSpeedScale(float speed)
        {
            NativeCalls.godot_icall_1_15(method_bind_25, Object.GetPtr(this), speed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_speed_scale");

        [GodotMethod("get_speed_scale")]
        [Obsolete("GetSpeedScale is deprecated. Use the PlaybackSpeed property instead.")]
        public float GetSpeedScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_26, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_playing_speed");

        /// <summary>
        /// <para>Gets the actual playing speed of current animation or 0 if not playing. This speed is the <see cref="Godot.AnimationPlayer.PlaybackSpeed"/> property multiplied by <c>custom_speed</c> argument specified when calling the <see cref="Godot.AnimationPlayer.Play"/> method.</para>
        /// </summary>
        [GodotMethod("get_playing_speed")]
        public float GetPlayingSpeed()
        {
            return NativeCalls.godot_icall_0_14(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_autoplay");

        [GodotMethod("set_autoplay")]
        [Obsolete("SetAutoplay is deprecated. Use the Autoplay property instead.")]
        public void SetAutoplay(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_28, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_autoplay");

        [GodotMethod("get_autoplay")]
        [Obsolete("GetAutoplay is deprecated. Use the Autoplay property instead.")]
        public string GetAutoplay()
        {
            return NativeCalls.godot_icall_0_6(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_reset_on_save_enabled");

        [GodotMethod("set_reset_on_save_enabled")]
        [Obsolete("SetResetOnSaveEnabled is deprecated. Use the ResetOnSave property instead.")]
        public void SetResetOnSaveEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_30, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_reset_on_save_enabled");

        [GodotMethod("is_reset_on_save_enabled")]
        [Obsolete("IsResetOnSaveEnabled is deprecated. Use the ResetOnSave property instead.")]
        public bool IsResetOnSaveEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_root");

        [GodotMethod("set_root")]
        [Obsolete("SetRoot is deprecated. Use the RootNode property instead.")]
        public void SetRoot(NodePath path)
        {
            NativeCalls.godot_icall_1_129(method_bind_32, Object.GetPtr(this), NodePath.GetPtr(path));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_root");

        [GodotMethod("get_root")]
        [Obsolete("GetRoot is deprecated. Use the RootNode property instead.")]
        public NodePath GetRoot()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_33, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "find_animation");

        /// <summary>
        /// <para>Returns the name of <c>animation</c> or an empty string if not found.</para>
        /// </summary>
        [GodotMethod("find_animation")]
        public string FindAnimation(Animation animation)
        {
            return NativeCalls.godot_icall_1_115(method_bind_34, Object.GetPtr(this), Object.GetPtr(animation));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_caches");

        /// <summary>
        /// <para><see cref="Godot.AnimationPlayer"/> caches animated nodes. It may not notice if a node disappears; <see cref="Godot.AnimationPlayer.ClearCaches"/> forces it to update the cache again.</para>
        /// </summary>
        [GodotMethod("clear_caches")]
        public void ClearCaches()
        {
            NativeCalls.godot_icall_0_3(method_bind_35, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_animation_process_mode");

        [GodotMethod("set_animation_process_mode")]
        [Obsolete("SetAnimationProcessMode is deprecated. Use the PlaybackProcessMode property instead.")]
        public void SetAnimationProcessMode(AnimationPlayer.AnimationProcessMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_36, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_animation_process_mode");

        [GodotMethod("get_animation_process_mode")]
        [Obsolete("GetAnimationProcessMode is deprecated. Use the PlaybackProcessMode property instead.")]
        public AnimationPlayer.AnimationProcessMode GetAnimationProcessMode()
        {
            return (AnimationPlayer.AnimationProcessMode)NativeCalls.godot_icall_0_131(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_method_call_mode");

        [GodotMethod("set_method_call_mode")]
        [Obsolete("SetMethodCallMode is deprecated. Use the MethodCallMode property instead.")]
        public void SetMethodCallMode(AnimationPlayer.AnimationMethodCallMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_38, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_method_call_mode");

        [GodotMethod("get_method_call_mode")]
        [Obsolete("GetMethodCallMode is deprecated. Use the MethodCallMode property instead.")]
        public AnimationPlayer.AnimationMethodCallMode GetMethodCallMode()
        {
            return (AnimationPlayer.AnimationMethodCallMode)NativeCalls.godot_icall_0_132(method_bind_39, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_animation_position");

        [GodotMethod("get_current_animation_position")]
        [Obsolete("GetCurrentAnimationPosition is deprecated. Use the CurrentAnimationPosition property instead.")]
        public float GetCurrentAnimationPosition()
        {
            return NativeCalls.godot_icall_0_14(method_bind_40, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_animation_length");

        [GodotMethod("get_current_animation_length")]
        [Obsolete("GetCurrentAnimationLength is deprecated. Use the CurrentAnimationLength property instead.")]
        public float GetCurrentAnimationLength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_41, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "seek");

        /// <summary>
        /// <para>Seeks the animation to the <c>seconds</c> point in time (in seconds). If <c>update</c> is <c>true</c>, the animation updates too, otherwise it updates at process time. Events between the current frame and <c>seconds</c> are skipped.</para>
        /// <para>Note: Seeking to the end of the animation doesn't emit <c>animation_finished</c>. If you want to skip animation and emit the signal, use <see cref="Godot.AnimationPlayer.Advance"/>.</para>
        /// </summary>
        [GodotMethod("seek")]
        public void Seek(float seconds, bool update = false)
        {
            NativeCalls.godot_icall_2_133(method_bind_42, Object.GetPtr(this), seconds, update);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "advance");

        /// <summary>
        /// <para>Shifts position in the animation timeline and immediately updates the animation. <c>delta</c> is the time in seconds to shift. Events between the current frame and <c>delta</c> are handled.</para>
        /// </summary>
        [GodotMethod("advance")]
        public void Advance(float delta)
        {
            NativeCalls.godot_icall_1_15(method_bind_43, Object.GetPtr(this), delta);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
