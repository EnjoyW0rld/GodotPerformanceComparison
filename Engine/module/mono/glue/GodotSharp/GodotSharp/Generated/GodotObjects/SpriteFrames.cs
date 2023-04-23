using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Sprite frame library for an <see cref="Godot.AnimatedSprite"/> or <see cref="Godot.AnimatedSprite3D"/> node. Contains frames and animation data for playback.</para>
    /// <para>Note: You can associate a set of normal maps by creating additional <see cref="Godot.SpriteFrames"/> resources with a <c>_normal</c> suffix. For example, having 2 <see cref="Godot.SpriteFrames"/> resources <c>run</c> and <c>run_normal</c> will make it so the <c>run</c> animation uses the normal map.</para>
    /// </summary>
    public partial class SpriteFrames : Resource
    {
        /// <summary>
        /// <para>Compatibility property, always equals to an empty array.</para>
        /// </summary>
        public Godot.Collections.Array Frames
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetFrames();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetFrames(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Animations
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetAnimations();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetAnimations(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "SpriteFrames";

        public SpriteFrames() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SpriteFrames_Ctor(this);
        }

        internal SpriteFrames(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_animation");

        /// <summary>
        /// <para>Adds a new animation to the library.</para>
        /// </summary>
        [GodotMethod("add_animation")]
        public void AddAnimation(string anim)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), anim);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_animation");

        /// <summary>
        /// <para>If <c>true</c>, the named animation exists.</para>
        /// </summary>
        [GodotMethod("has_animation")]
        public bool HasAnimation(string anim)
        {
            return NativeCalls.godot_icall_1_108(method_bind_1, Object.GetPtr(this), anim);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_animation");

        /// <summary>
        /// <para>Removes the given animation.</para>
        /// </summary>
        [GodotMethod("remove_animation")]
        public void RemoveAnimation(string anim)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), anim);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rename_animation");

        /// <summary>
        /// <para>Changes the animation's name to <c>newname</c>.</para>
        /// </summary>
        [GodotMethod("rename_animation")]
        public void RenameAnimation(string anim, string newname)
        {
            NativeCalls.godot_icall_2_107(method_bind_3, Object.GetPtr(this), anim, newname);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_animation_names");

        /// <summary>
        /// <para>Returns an array containing the names associated to each animation. Values are placed in alphabetical order.</para>
        /// </summary>
        [GodotMethod("get_animation_names")]
        public string[] GetAnimationNames()
        {
            return NativeCalls.godot_icall_0_119(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_animation_speed");

        /// <summary>
        /// <para>The animation's speed in frames per second.</para>
        /// </summary>
        [GodotMethod("set_animation_speed")]
        public void SetAnimationSpeed(string anim, float speed)
        {
            NativeCalls.godot_icall_2_128(method_bind_5, Object.GetPtr(this), anim, speed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_animation_speed");

        /// <summary>
        /// <para>The animation's speed in frames per second.</para>
        /// </summary>
        [GodotMethod("get_animation_speed")]
        public float GetAnimationSpeed(string anim)
        {
            return NativeCalls.godot_icall_1_140(method_bind_6, Object.GetPtr(this), anim);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_animation_loop");

        /// <summary>
        /// <para>If <c>true</c>, the animation will loop.</para>
        /// </summary>
        [GodotMethod("set_animation_loop")]
        public void SetAnimationLoop(string anim, bool loop)
        {
            NativeCalls.godot_icall_2_56(method_bind_7, Object.GetPtr(this), anim, loop);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_animation_loop");

        /// <summary>
        /// <para>Returns <c>true</c> if the given animation is configured to loop when it finishes playing. Otherwise, returns <c>false</c>.</para>
        /// </summary>
        [GodotMethod("get_animation_loop")]
        public bool GetAnimationLoop(string anim)
        {
            return NativeCalls.godot_icall_1_108(method_bind_8, Object.GetPtr(this), anim);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_frame");

        /// <summary>
        /// <para>Adds a frame to the given animation.</para>
        /// </summary>
        [GodotMethod("add_frame")]
        public void AddFrame(string anim, Texture frame, int atPosition = -1)
        {
            NativeCalls.godot_icall_3_882(method_bind_9, Object.GetPtr(this), anim, Object.GetPtr(frame), atPosition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frame_count");

        /// <summary>
        /// <para>Returns the number of frames in the animation.</para>
        /// </summary>
        [GodotMethod("get_frame_count")]
        public int GetFrameCount(string anim)
        {
            return NativeCalls.godot_icall_1_138(method_bind_10, Object.GetPtr(this), anim);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frame");

        /// <summary>
        /// <para>Returns the animation's selected frame.</para>
        /// </summary>
        [GodotMethod("get_frame")]
        public Texture GetFrame(string anim, int idx)
        {
            return NativeCalls.godot_icall_2_883(method_bind_11, Object.GetPtr(this), anim, idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_frame");

        /// <summary>
        /// <para>Sets the texture of the given frame.</para>
        /// </summary>
        [GodotMethod("set_frame")]
        public void SetFrame(string anim, int idx, Texture txt)
        {
            NativeCalls.godot_icall_3_884(method_bind_12, Object.GetPtr(this), anim, idx, Object.GetPtr(txt));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_frame");

        /// <summary>
        /// <para>Removes the animation's selected frame.</para>
        /// </summary>
        [GodotMethod("remove_frame")]
        public void RemoveFrame(string anim, int idx)
        {
            NativeCalls.godot_icall_2_110(method_bind_13, Object.GetPtr(this), anim, idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Removes all frames from the given animation.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear(string anim)
        {
            NativeCalls.godot_icall_1_54(method_bind_14, Object.GetPtr(this), anim);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_all");

        /// <summary>
        /// <para>Removes all animations. A "default" animation will be created.</para>
        /// </summary>
        [GodotMethod("clear_all")]
        public void ClearAll()
        {
            NativeCalls.godot_icall_0_3(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_frames");

        [Obsolete("_SetFrames is deprecated. Use the Frames property instead.")]
        internal void _SetFrames(Godot.Collections.Array arg0)
        {
            NativeCalls.godot_icall_1_92(method_bind_16, Object.GetPtr(this), arg0.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_frames");

        [Obsolete("_GetFrames is deprecated. Use the Frames property instead.")]
        internal Godot.Collections.Array _GetFrames()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_17, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_animations");

        [Obsolete("_SetAnimations is deprecated. Use the Animations property instead.")]
        internal void _SetAnimations(Godot.Collections.Array arg0)
        {
            NativeCalls.godot_icall_1_92(method_bind_18, Object.GetPtr(this), arg0.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_animations");

        [Obsolete("_GetAnimations is deprecated. Use the Animations property instead.")]
        internal Godot.Collections.Array _GetAnimations()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_19, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
