using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>An Animation resource contains data used to animate everything in the engine. Animations are divided into tracks, and each track must be linked to a node. The state of that node can be changed through time, by adding timed keys (events) to the track.</para>
    /// <para><code>
    /// # This creates an animation that makes the node "Enemy" move to the right by
    /// # 100 pixels in 0.5 seconds.
    /// var animation = Animation.new()
    /// var track_index = animation.add_track(Animation.TYPE_VALUE)
    /// animation.track_set_path(track_index, "Enemy:position:x")
    /// animation.track_insert_key(track_index, 0.0, 0)
    /// animation.track_insert_key(track_index, 0.5, 100)
    /// </code></para>
    /// <para>Animations are just data containers, and must be added to nodes such as an <see cref="Godot.AnimationPlayer"/> or <see cref="Godot.AnimationTreePlayer"/> to be played back. Animation tracks have different types, each with its own set of dedicated methods. Check <see cref="Godot.Animation.TrackType"/> to see available types.</para>
    /// </summary>
    public partial class Animation : Resource
    {
        public enum TrackType
        {
            /// <summary>
            /// <para>Value tracks set values in node properties, but only those which can be Interpolated.</para>
            /// </summary>
            Value = 0,
            /// <summary>
            /// <para>Transform tracks are used to change node local transforms or skeleton pose bones. Transitions are interpolated.</para>
            /// </summary>
            Transform = 1,
            /// <summary>
            /// <para>Method tracks call functions with given arguments per key.</para>
            /// </summary>
            Method = 2,
            /// <summary>
            /// <para>Bezier tracks are used to interpolate a value using custom curves. They can also be used to animate sub-properties of vectors and colors (e.g. alpha value of a <see cref="Godot.Color"/>).</para>
            /// </summary>
            Bezier = 3,
            /// <summary>
            /// <para>Audio tracks are used to play an audio stream with either type of <see cref="Godot.AudioStreamPlayer"/>. The stream can be trimmed and previewed in the animation.</para>
            /// </summary>
            Audio = 4,
            /// <summary>
            /// <para>Animation tracks play animations in other <see cref="Godot.AnimationPlayer"/> nodes.</para>
            /// </summary>
            Animation = 5
        }

        public enum UpdateMode
        {
            /// <summary>
            /// <para>Update between keyframes.</para>
            /// </summary>
            Continuous = 0,
            /// <summary>
            /// <para>Update at the keyframes and hold the value.</para>
            /// </summary>
            Discrete = 1,
            /// <summary>
            /// <para>Update at the keyframes.</para>
            /// </summary>
            Trigger = 2,
            /// <summary>
            /// <para>Same as linear interpolation, but also interpolates from the current value (i.e. dynamically at runtime) if the first key isn't at 0 seconds.</para>
            /// </summary>
            Capture = 3
        }

        public enum InterpolationType
        {
            /// <summary>
            /// <para>No interpolation (nearest value).</para>
            /// </summary>
            Nearest = 0,
            /// <summary>
            /// <para>Linear interpolation.</para>
            /// </summary>
            Linear = 1,
            /// <summary>
            /// <para>Cubic interpolation.</para>
            /// </summary>
            Cubic = 2
        }

        /// <summary>
        /// <para>The total length of the animation (in seconds).</para>
        /// <para>Note: Length is not delimited by the last key, as this one may be before or after the end to ensure correct interpolation and looping.</para>
        /// </summary>
        public float Length
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLength(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A flag indicating that the animation must loop. This is used for correct interpolation of animation cycles, and for hinting the player that it must restart the animation.</para>
        /// </summary>
        public bool Loop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return HasLoop();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLoop(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The animation step value.</para>
        /// </summary>
        public float Step
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStep();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStep(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Animation";

        public Animation() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Animation_Ctor(this);
        }

        internal Animation(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_track");

        /// <summary>
        /// <para>Adds a track to the Animation.</para>
        /// </summary>
        [GodotMethod("add_track")]
        public int AddTrack(Animation.TrackType type, int atPosition = -1)
        {
            return NativeCalls.godot_icall_2_60(method_bind_0, Object.GetPtr(this), (int)type, atPosition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_track");

        /// <summary>
        /// <para>Removes a track by specifying the track index.</para>
        /// </summary>
        [GodotMethod("remove_track")]
        public void RemoveTrack(int trackIdx)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), trackIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_track_count");

        /// <summary>
        /// <para>Returns the amount of tracks in the animation.</para>
        /// </summary>
        [GodotMethod("get_track_count")]
        public int GetTrackCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_get_type");

        /// <summary>
        /// <para>Gets the type of a track.</para>
        /// </summary>
        [GodotMethod("track_get_type")]
        public Animation.TrackType TrackGetType(int trackIdx)
        {
            return (Animation.TrackType)NativeCalls.godot_icall_1_61(method_bind_3, Object.GetPtr(this), trackIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_get_path");

        /// <summary>
        /// <para>Gets the path of a track. For more information on the path format, see <see cref="Godot.Animation.TrackSetPath"/>.</para>
        /// </summary>
        [GodotMethod("track_get_path")]
        public NodePath TrackGetPath(int trackIdx)
        {
            return new NodePath(NativeCalls.godot_icall_1_62(method_bind_4, Object.GetPtr(this), trackIdx));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_set_path");

        /// <summary>
        /// <para>Sets the path of a track. Paths must be valid scene-tree paths to a node and must be specified starting from the parent node of the node that will reproduce the animation. Tracks that control properties or bones must append their name after the path, separated by <c>":"</c>.</para>
        /// <para>For example, <c>"character/skeleton:ankle"</c> or <c>"character/mesh:transform/local"</c>.</para>
        /// </summary>
        [GodotMethod("track_set_path")]
        public void TrackSetPath(int trackIdx, NodePath path)
        {
            NativeCalls.godot_icall_2_63(method_bind_5, Object.GetPtr(this), trackIdx, NodePath.GetPtr(path));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "find_track");

        /// <summary>
        /// <para>Returns the index of the specified track. If the track is not found, return -1.</para>
        /// </summary>
        [GodotMethod("find_track")]
        public int FindTrack(NodePath path)
        {
            return NativeCalls.godot_icall_1_64(method_bind_6, Object.GetPtr(this), NodePath.GetPtr(path));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_move_up");

        /// <summary>
        /// <para>Moves a track up.</para>
        /// </summary>
        [GodotMethod("track_move_up")]
        public void TrackMoveUp(int trackIdx)
        {
            NativeCalls.godot_icall_1_4(method_bind_7, Object.GetPtr(this), trackIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_move_down");

        /// <summary>
        /// <para>Moves a track down.</para>
        /// </summary>
        [GodotMethod("track_move_down")]
        public void TrackMoveDown(int trackIdx)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), trackIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_move_to");

        /// <summary>
        /// <para>Changes the index position of track <c>idx</c> to the one defined in <c>to_idx</c>.</para>
        /// </summary>
        [GodotMethod("track_move_to")]
        public void TrackMoveTo(int trackIdx, int toIdx)
        {
            NativeCalls.godot_icall_2_65(method_bind_9, Object.GetPtr(this), trackIdx, toIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_swap");

        /// <summary>
        /// <para>Swaps the track <c>idx</c>'s index position with the track <c>with_idx</c>.</para>
        /// </summary>
        [GodotMethod("track_swap")]
        public void TrackSwap(int trackIdx, int withIdx)
        {
            NativeCalls.godot_icall_2_65(method_bind_10, Object.GetPtr(this), trackIdx, withIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_set_imported");

        /// <summary>
        /// <para>Sets the given track as imported or not.</para>
        /// </summary>
        [GodotMethod("track_set_imported")]
        public void TrackSetImported(int trackIdx, bool imported)
        {
            NativeCalls.godot_icall_2_23(method_bind_11, Object.GetPtr(this), trackIdx, imported);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_is_imported");

        /// <summary>
        /// <para>Returns <c>true</c> if the given track is imported. Else, return <c>false</c>.</para>
        /// </summary>
        [GodotMethod("track_is_imported")]
        public bool TrackIsImported(int trackIdx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_12, Object.GetPtr(this), trackIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_set_enabled");

        /// <summary>
        /// <para>Enables/disables the given track. Tracks are enabled by default.</para>
        /// </summary>
        [GodotMethod("track_set_enabled")]
        public void TrackSetEnabled(int trackIdx, bool enabled)
        {
            NativeCalls.godot_icall_2_23(method_bind_13, Object.GetPtr(this), trackIdx, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_is_enabled");

        /// <summary>
        /// <para>Returns <c>true</c> if the track at index <c>idx</c> is enabled.</para>
        /// </summary>
        [GodotMethod("track_is_enabled")]
        public bool TrackIsEnabled(int trackIdx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_14, Object.GetPtr(this), trackIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "transform_track_insert_key");

        /// <summary>
        /// <para>Insert a transform key for a transform track.</para>
        /// </summary>
        [GodotMethod("transform_track_insert_key")]
        public int TransformTrackInsertKey(int trackIdx, float time, Vector3 location, Quat rotation, Vector3 scale)
        {
            return NativeCalls.godot_icall_5_66(method_bind_15, Object.GetPtr(this), trackIdx, time, ref location, ref rotation, ref scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_insert_key");

        /// <summary>
        /// <para>Insert a generic key in a given track.</para>
        /// </summary>
        [GodotMethod("track_insert_key")]
        public void TrackInsertKey(int trackIdx, float time, object key, float transition = (float)1)
        {
            NativeCalls.godot_icall_4_67(method_bind_16, Object.GetPtr(this), trackIdx, time, key, transition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_remove_key");

        /// <summary>
        /// <para>Removes a key by index in a given track.</para>
        /// </summary>
        [GodotMethod("track_remove_key")]
        public void TrackRemoveKey(int trackIdx, int keyIdx)
        {
            NativeCalls.godot_icall_2_65(method_bind_17, Object.GetPtr(this), trackIdx, keyIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_remove_key_at_position");

        /// <summary>
        /// <para>Removes a key by position (seconds) in a given track.</para>
        /// </summary>
        [GodotMethod("track_remove_key_at_position")]
        public void TrackRemoveKeyAtPosition(int trackIdx, float position)
        {
            NativeCalls.godot_icall_2_34(method_bind_18, Object.GetPtr(this), trackIdx, position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_set_key_value");

        /// <summary>
        /// <para>Sets the value of an existing key.</para>
        /// </summary>
        [GodotMethod("track_set_key_value")]
        public void TrackSetKeyValue(int trackIdx, int key, object value)
        {
            NativeCalls.godot_icall_3_68(method_bind_19, Object.GetPtr(this), trackIdx, key, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_set_key_transition");

        /// <summary>
        /// <para>Sets the transition curve (easing) for a specific key (see the built-in math function <c>@GDScript.ease</c>).</para>
        /// </summary>
        [GodotMethod("track_set_key_transition")]
        public void TrackSetKeyTransition(int trackIdx, int keyIdx, float transition)
        {
            NativeCalls.godot_icall_3_69(method_bind_20, Object.GetPtr(this), trackIdx, keyIdx, transition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_set_key_time");

        /// <summary>
        /// <para>Sets the time of an existing key.</para>
        /// </summary>
        [GodotMethod("track_set_key_time")]
        public void TrackSetKeyTime(int trackIdx, int keyIdx, float time)
        {
            NativeCalls.godot_icall_3_69(method_bind_21, Object.GetPtr(this), trackIdx, keyIdx, time);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_get_key_transition");

        /// <summary>
        /// <para>Returns the transition curve (easing) for a specific key (see the built-in math function <c>@GDScript.ease</c>).</para>
        /// </summary>
        [GodotMethod("track_get_key_transition")]
        public float TrackGetKeyTransition(int trackIdx, int keyIdx)
        {
            return NativeCalls.godot_icall_2_70(method_bind_22, Object.GetPtr(this), trackIdx, keyIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_get_key_count");

        /// <summary>
        /// <para>Returns the amount of keys in a given track.</para>
        /// </summary>
        [GodotMethod("track_get_key_count")]
        public int TrackGetKeyCount(int trackIdx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_23, Object.GetPtr(this), trackIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_get_key_value");

        /// <summary>
        /// <para>Returns the value of a given key in a given track.</para>
        /// </summary>
        [GodotMethod("track_get_key_value")]
        public object TrackGetKeyValue(int trackIdx, int keyIdx)
        {
            return NativeCalls.godot_icall_2_71(method_bind_24, Object.GetPtr(this), trackIdx, keyIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_get_key_time");

        /// <summary>
        /// <para>Returns the time at which the key is located.</para>
        /// </summary>
        [GodotMethod("track_get_key_time")]
        public float TrackGetKeyTime(int trackIdx, int keyIdx)
        {
            return NativeCalls.godot_icall_2_70(method_bind_25, Object.GetPtr(this), trackIdx, keyIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_find_key");

        /// <summary>
        /// <para>Finds the key index by time in a given track. Optionally, only find it if the exact time is given.</para>
        /// </summary>
        [GodotMethod("track_find_key")]
        public int TrackFindKey(int trackIdx, float time, bool exact = false)
        {
            return NativeCalls.godot_icall_3_72(method_bind_26, Object.GetPtr(this), trackIdx, time, exact);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_set_interpolation_type");

        /// <summary>
        /// <para>Sets the interpolation type of a given track.</para>
        /// </summary>
        [GodotMethod("track_set_interpolation_type")]
        public void TrackSetInterpolationType(int trackIdx, Animation.InterpolationType interpolation)
        {
            NativeCalls.godot_icall_2_65(method_bind_27, Object.GetPtr(this), trackIdx, (int)interpolation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_get_interpolation_type");

        /// <summary>
        /// <para>Returns the interpolation type of a given track.</para>
        /// </summary>
        [GodotMethod("track_get_interpolation_type")]
        public Animation.InterpolationType TrackGetInterpolationType(int trackIdx)
        {
            return (Animation.InterpolationType)NativeCalls.godot_icall_1_73(method_bind_28, Object.GetPtr(this), trackIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_set_interpolation_loop_wrap");

        /// <summary>
        /// <para>If <c>true</c>, the track at <c>idx</c> wraps the interpolation loop.</para>
        /// </summary>
        [GodotMethod("track_set_interpolation_loop_wrap")]
        public void TrackSetInterpolationLoopWrap(int trackIdx, bool interpolation)
        {
            NativeCalls.godot_icall_2_23(method_bind_29, Object.GetPtr(this), trackIdx, interpolation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "track_get_interpolation_loop_wrap");

        /// <summary>
        /// <para>Returns <c>true</c> if the track at <c>idx</c> wraps the interpolation loop. New tracks wrap the interpolation loop by default.</para>
        /// </summary>
        [GodotMethod("track_get_interpolation_loop_wrap")]
        public bool TrackGetInterpolationLoopWrap(int trackIdx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_30, Object.GetPtr(this), trackIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "transform_track_interpolate");

        /// <summary>
        /// <para>Returns the interpolated value of a transform track at a given time (in seconds). An array consisting of 3 elements: position (<see cref="Godot.Vector3"/>), rotation (<see cref="Godot.Quat"/>) and scale (<see cref="Godot.Vector3"/>).</para>
        /// </summary>
        [GodotMethod("transform_track_interpolate")]
        public Godot.Collections.Array TransformTrackInterpolate(int trackIdx, float timeSec)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_74(method_bind_31, Object.GetPtr(this), trackIdx, timeSec));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "value_track_set_update_mode");

        /// <summary>
        /// <para>Sets the update mode (see <see cref="Godot.Animation.UpdateMode"/>) of a value track.</para>
        /// </summary>
        [GodotMethod("value_track_set_update_mode")]
        public void ValueTrackSetUpdateMode(int trackIdx, Animation.UpdateMode mode)
        {
            NativeCalls.godot_icall_2_65(method_bind_32, Object.GetPtr(this), trackIdx, (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "value_track_get_update_mode");

        /// <summary>
        /// <para>Returns the update mode of a value track.</para>
        /// </summary>
        [GodotMethod("value_track_get_update_mode")]
        public Animation.UpdateMode ValueTrackGetUpdateMode(int trackIdx)
        {
            return (Animation.UpdateMode)NativeCalls.godot_icall_1_75(method_bind_33, Object.GetPtr(this), trackIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "value_track_get_key_indices");

        /// <summary>
        /// <para>Returns all the key indices of a value track, given a position and delta time.</para>
        /// </summary>
        [GodotMethod("value_track_get_key_indices")]
        public int[] ValueTrackGetKeyIndices(int trackIdx, float timeSec, float delta)
        {
            return NativeCalls.godot_icall_3_76(method_bind_34, Object.GetPtr(this), trackIdx, timeSec, delta);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "value_track_interpolate");

        /// <summary>
        /// <para>Returns the interpolated value at the given time (in seconds). The <c>track_idx</c> must be the index of a value track.</para>
        /// </summary>
        [GodotMethod("value_track_interpolate")]
        public object ValueTrackInterpolate(int trackIdx, float timeSec)
        {
            return NativeCalls.godot_icall_2_77(method_bind_35, Object.GetPtr(this), trackIdx, timeSec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "method_track_get_key_indices");

        /// <summary>
        /// <para>Returns all the key indices of a method track, given a position and delta time.</para>
        /// </summary>
        [GodotMethod("method_track_get_key_indices")]
        public int[] MethodTrackGetKeyIndices(int trackIdx, float timeSec, float delta)
        {
            return NativeCalls.godot_icall_3_76(method_bind_36, Object.GetPtr(this), trackIdx, timeSec, delta);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "method_track_get_name");

        /// <summary>
        /// <para>Returns the method name of a method track.</para>
        /// </summary>
        [GodotMethod("method_track_get_name")]
        public string MethodTrackGetName(int trackIdx, int keyIdx)
        {
            return NativeCalls.godot_icall_2_78(method_bind_37, Object.GetPtr(this), trackIdx, keyIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "method_track_get_params");

        /// <summary>
        /// <para>Returns the arguments values to be called on a method track for a given key in a given track.</para>
        /// </summary>
        [GodotMethod("method_track_get_params")]
        public Godot.Collections.Array MethodTrackGetParams(int trackIdx, int keyIdx)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_79(method_bind_38, Object.GetPtr(this), trackIdx, keyIdx));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "bezier_track_insert_key");

        /// <summary>
        /// <para>Inserts a Bezier Track key at the given <c>time</c> in seconds. The <c>track_idx</c> must be the index of a Bezier Track.</para>
        /// <para><c>in_handle</c> is the left-side weight of the added Bezier curve point, <c>out_handle</c> is the right-side one, while <c>value</c> is the actual value at this point.</para>
        /// </summary>
        /// <param name="inHandle">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        /// <param name="outHandle">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("bezier_track_insert_key")]
        public int BezierTrackInsertKey(int trackIdx, float time, float value, Nullable<Vector2> inHandle = null, Nullable<Vector2> outHandle = null)
        {
            Vector2 inHandle_in = inHandle.HasValue ? inHandle.Value : new Vector2(0, 0);
            Vector2 outHandle_in = outHandle.HasValue ? outHandle.Value : new Vector2(0, 0);
            return NativeCalls.godot_icall_5_80(method_bind_39, Object.GetPtr(this), trackIdx, time, value, ref inHandle_in, ref outHandle_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "bezier_track_set_key_value");

        /// <summary>
        /// <para>Sets the value of the key identified by <c>key_idx</c> to the given value. The <c>track_idx</c> must be the index of a Bezier Track.</para>
        /// </summary>
        [GodotMethod("bezier_track_set_key_value")]
        public void BezierTrackSetKeyValue(int trackIdx, int keyIdx, float value)
        {
            NativeCalls.godot_icall_3_69(method_bind_40, Object.GetPtr(this), trackIdx, keyIdx, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "bezier_track_set_key_in_handle");

        /// <summary>
        /// <para>Sets the in handle of the key identified by <c>key_idx</c> to value <c>in_handle</c>. The <c>track_idx</c> must be the index of a Bezier Track.</para>
        /// </summary>
        [GodotMethod("bezier_track_set_key_in_handle")]
        public void BezierTrackSetKeyInHandle(int trackIdx, int keyIdx, Vector2 inHandle)
        {
            NativeCalls.godot_icall_3_81(method_bind_41, Object.GetPtr(this), trackIdx, keyIdx, ref inHandle);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "bezier_track_set_key_out_handle");

        /// <summary>
        /// <para>Sets the out handle of the key identified by <c>key_idx</c> to value <c>out_handle</c>. The <c>track_idx</c> must be the index of a Bezier Track.</para>
        /// </summary>
        [GodotMethod("bezier_track_set_key_out_handle")]
        public void BezierTrackSetKeyOutHandle(int trackIdx, int keyIdx, Vector2 outHandle)
        {
            NativeCalls.godot_icall_3_81(method_bind_42, Object.GetPtr(this), trackIdx, keyIdx, ref outHandle);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "bezier_track_get_key_value");

        /// <summary>
        /// <para>Returns the value of the key identified by <c>key_idx</c>. The <c>track_idx</c> must be the index of a Bezier Track.</para>
        /// </summary>
        [GodotMethod("bezier_track_get_key_value")]
        public float BezierTrackGetKeyValue(int trackIdx, int keyIdx)
        {
            return NativeCalls.godot_icall_2_70(method_bind_43, Object.GetPtr(this), trackIdx, keyIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "bezier_track_get_key_in_handle");

        /// <summary>
        /// <para>Returns the in handle of the key identified by <c>key_idx</c>. The <c>track_idx</c> must be the index of a Bezier Track.</para>
        /// </summary>
        [GodotMethod("bezier_track_get_key_in_handle")]
        public Vector2 BezierTrackGetKeyInHandle(int trackIdx, int keyIdx)
        {
            NativeCalls.godot_icall_2_82(method_bind_44, Object.GetPtr(this), trackIdx, keyIdx, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "bezier_track_get_key_out_handle");

        /// <summary>
        /// <para>Returns the out handle of the key identified by <c>key_idx</c>. The <c>track_idx</c> must be the index of a Bezier Track.</para>
        /// </summary>
        [GodotMethod("bezier_track_get_key_out_handle")]
        public Vector2 BezierTrackGetKeyOutHandle(int trackIdx, int keyIdx)
        {
            NativeCalls.godot_icall_2_82(method_bind_45, Object.GetPtr(this), trackIdx, keyIdx, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "bezier_track_interpolate");

        /// <summary>
        /// <para>Returns the interpolated value at the given <c>time</c> (in seconds). The <c>track_idx</c> must be the index of a Bezier Track.</para>
        /// </summary>
        [GodotMethod("bezier_track_interpolate")]
        public float BezierTrackInterpolate(int trackIdx, float time)
        {
            return NativeCalls.godot_icall_2_83(method_bind_46, Object.GetPtr(this), trackIdx, time);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "audio_track_insert_key");

        /// <summary>
        /// <para>Inserts an Audio Track key at the given <c>time</c> in seconds. The <c>track_idx</c> must be the index of an Audio Track.</para>
        /// <para><c>stream</c> is the <see cref="Godot.AudioStream"/> resource to play. <c>start_offset</c> is the number of seconds cut off at the beginning of the audio stream, while <c>end_offset</c> is at the ending.</para>
        /// </summary>
        [GodotMethod("audio_track_insert_key")]
        public int AudioTrackInsertKey(int trackIdx, float time, Resource stream, float startOffset = (float)0, float endOffset = (float)0)
        {
            return NativeCalls.godot_icall_5_84(method_bind_47, Object.GetPtr(this), trackIdx, time, Object.GetPtr(stream), startOffset, endOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "audio_track_set_key_stream");

        /// <summary>
        /// <para>Sets the stream of the key identified by <c>key_idx</c> to value <c>stream</c>. The <c>track_idx</c> must be the index of an Audio Track.</para>
        /// </summary>
        [GodotMethod("audio_track_set_key_stream")]
        public void AudioTrackSetKeyStream(int trackIdx, int keyIdx, Resource stream)
        {
            NativeCalls.godot_icall_3_85(method_bind_48, Object.GetPtr(this), trackIdx, keyIdx, Object.GetPtr(stream));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "audio_track_set_key_start_offset");

        /// <summary>
        /// <para>Sets the start offset of the key identified by <c>key_idx</c> to value <c>offset</c>. The <c>track_idx</c> must be the index of an Audio Track.</para>
        /// </summary>
        [GodotMethod("audio_track_set_key_start_offset")]
        public void AudioTrackSetKeyStartOffset(int trackIdx, int keyIdx, float offset)
        {
            NativeCalls.godot_icall_3_69(method_bind_49, Object.GetPtr(this), trackIdx, keyIdx, offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "audio_track_set_key_end_offset");

        /// <summary>
        /// <para>Sets the end offset of the key identified by <c>key_idx</c> to value <c>offset</c>. The <c>track_idx</c> must be the index of an Audio Track.</para>
        /// </summary>
        [GodotMethod("audio_track_set_key_end_offset")]
        public void AudioTrackSetKeyEndOffset(int trackIdx, int keyIdx, float offset)
        {
            NativeCalls.godot_icall_3_69(method_bind_50, Object.GetPtr(this), trackIdx, keyIdx, offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "audio_track_get_key_stream");

        /// <summary>
        /// <para>Returns the audio stream of the key identified by <c>key_idx</c>. The <c>track_idx</c> must be the index of an Audio Track.</para>
        /// </summary>
        [GodotMethod("audio_track_get_key_stream")]
        public Resource AudioTrackGetKeyStream(int trackIdx, int keyIdx)
        {
            return NativeCalls.godot_icall_2_86(method_bind_51, Object.GetPtr(this), trackIdx, keyIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "audio_track_get_key_start_offset");

        /// <summary>
        /// <para>Returns the start offset of the key identified by <c>key_idx</c>. The <c>track_idx</c> must be the index of an Audio Track.</para>
        /// <para>Start offset is the number of seconds cut off at the beginning of the audio stream.</para>
        /// </summary>
        [GodotMethod("audio_track_get_key_start_offset")]
        public float AudioTrackGetKeyStartOffset(int trackIdx, int keyIdx)
        {
            return NativeCalls.godot_icall_2_70(method_bind_52, Object.GetPtr(this), trackIdx, keyIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "audio_track_get_key_end_offset");

        /// <summary>
        /// <para>Returns the end offset of the key identified by <c>key_idx</c>. The <c>track_idx</c> must be the index of an Audio Track.</para>
        /// <para>End offset is the number of seconds cut off at the ending of the audio stream.</para>
        /// </summary>
        [GodotMethod("audio_track_get_key_end_offset")]
        public float AudioTrackGetKeyEndOffset(int trackIdx, int keyIdx)
        {
            return NativeCalls.godot_icall_2_70(method_bind_53, Object.GetPtr(this), trackIdx, keyIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "animation_track_insert_key");

        /// <summary>
        /// <para>Inserts a key with value <c>animation</c> at the given <c>time</c> (in seconds). The <c>track_idx</c> must be the index of an Animation Track.</para>
        /// </summary>
        [GodotMethod("animation_track_insert_key")]
        public int AnimationTrackInsertKey(int trackIdx, float time, string animation)
        {
            return NativeCalls.godot_icall_3_87(method_bind_54, Object.GetPtr(this), trackIdx, time, animation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "animation_track_set_key_animation");

        /// <summary>
        /// <para>Sets the key identified by <c>key_idx</c> to value <c>animation</c>. The <c>track_idx</c> must be the index of an Animation Track.</para>
        /// </summary>
        [GodotMethod("animation_track_set_key_animation")]
        public void AnimationTrackSetKeyAnimation(int trackIdx, int keyIdx, string animation)
        {
            NativeCalls.godot_icall_3_88(method_bind_55, Object.GetPtr(this), trackIdx, keyIdx, animation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "animation_track_get_key_animation");

        /// <summary>
        /// <para>Returns the animation name at the key identified by <c>key_idx</c>. The <c>track_idx</c> must be the index of an Animation Track.</para>
        /// </summary>
        [GodotMethod("animation_track_get_key_animation")]
        public string AnimationTrackGetKeyAnimation(int trackIdx, int keyIdx)
        {
            return NativeCalls.godot_icall_2_78(method_bind_56, Object.GetPtr(this), trackIdx, keyIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_length");

        [GodotMethod("set_length")]
        [Obsolete("SetLength is deprecated. Use the Length property instead.")]
        public void SetLength(float timeSec)
        {
            NativeCalls.godot_icall_1_15(method_bind_57, Object.GetPtr(this), timeSec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_length");

        [GodotMethod("get_length")]
        [Obsolete("GetLength is deprecated. Use the Length property instead.")]
        public float GetLength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_58, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_loop");

        [GodotMethod("set_loop")]
        [Obsolete("SetLoop is deprecated. Use the Loop property instead.")]
        public void SetLoop(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_59, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_loop");

        [GodotMethod("has_loop")]
        [Obsolete("HasLoop is deprecated. Use the Loop property instead.")]
        public bool HasLoop()
        {
            return NativeCalls.godot_icall_0_7(method_bind_60, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_step");

        [GodotMethod("set_step")]
        [Obsolete("SetStep is deprecated. Use the Step property instead.")]
        public void SetStep(float sizeSec)
        {
            NativeCalls.godot_icall_1_15(method_bind_61, Object.GetPtr(this), sizeSec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_step");

        [GodotMethod("get_step")]
        [Obsolete("GetStep is deprecated. Use the Step property instead.")]
        public float GetStep()
        {
            return NativeCalls.godot_icall_0_14(method_bind_62, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clear the animation (clear all tracks and reset all).</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_63, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_64 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "copy_track");

        /// <summary>
        /// <para>Adds a new track that is a copy of the given track from <c>to_animation</c>.</para>
        /// </summary>
        [GodotMethod("copy_track")]
        public void CopyTrack(int trackIdx, Animation toAnimation)
        {
            NativeCalls.godot_icall_2_58(method_bind_64, Object.GetPtr(this), trackIdx, Object.GetPtr(toAnimation));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
