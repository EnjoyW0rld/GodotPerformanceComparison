using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Animations are created using a <see cref="Godot.SpriteFrames"/> resource, which can be configured in the editor via the SpriteFrames panel.</para>
    /// </summary>
    public partial class AnimatedSprite3D : SpriteBase3D
    {
        /// <summary>
        /// <para>The <see cref="Godot.SpriteFrames"/> resource containing the animation(s).</para>
        /// </summary>
        public SpriteFrames Frames
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpriteFrames();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpriteFrames(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The current animation from the <c>frames</c> resource. If this value changes, the <c>frame</c> counter is reset.</para>
        /// </summary>
        public string Animation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAnimation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAnimation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The displayed animation frame's index.</para>
        /// </summary>
        public int Frame
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrame();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrame(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the <see cref="Godot.AnimatedSprite3D.Animation"/> is currently playing.</para>
        /// </summary>
        public bool Playing
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _IsPlaying();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetPlaying(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AnimatedSprite3D";

        public AnimatedSprite3D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimatedSprite3D_Ctor(this);
        }

        internal AnimatedSprite3D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sprite_frames");

        [GodotMethod("set_sprite_frames")]
        [Obsolete("SetSpriteFrames is deprecated. Use the Frames property instead.")]
        public void SetSpriteFrames(SpriteFrames spriteFrames)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(spriteFrames));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sprite_frames");

        [GodotMethod("get_sprite_frames")]
        [Obsolete("GetSpriteFrames is deprecated. Use the Frames property instead.")]
        public SpriteFrames GetSpriteFrames()
        {
            return NativeCalls.godot_icall_0_55(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_animation");

        [GodotMethod("set_animation")]
        [Obsolete("SetAnimation is deprecated. Use the Animation property instead.")]
        public void SetAnimation(string animation)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), animation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_animation");

        [GodotMethod("get_animation")]
        [Obsolete("GetAnimation is deprecated. Use the Animation property instead.")]
        public string GetAnimation()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_playing");

        [Obsolete("_SetPlaying is deprecated. Use the Playing property instead.")]
        internal void _SetPlaying(bool playing)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), playing);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_is_playing");

        [Obsolete("_IsPlaying is deprecated. Use the Playing property instead.")]
        internal bool _IsPlaying()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "play");

        /// <summary>
        /// <para>Plays the animation named <c>anim</c>. If no <c>anim</c> is provided, the current animation is played.</para>
        /// </summary>
        [GodotMethod("play")]
        public void Play(string anim = "")
        {
            NativeCalls.godot_icall_1_54(method_bind_6, Object.GetPtr(this), anim);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "stop");

        /// <summary>
        /// <para>Stops the current animation (does not reset the frame counter).</para>
        /// </summary>
        [GodotMethod("stop")]
        public void Stop()
        {
            NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_playing");

        /// <summary>
        /// <para>Returns <c>true</c> if an animation is currently being played.</para>
        /// </summary>
        [GodotMethod("is_playing")]
        public bool IsPlaying()
        {
            return NativeCalls.godot_icall_0_7(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_frame");

        [GodotMethod("set_frame")]
        [Obsolete("SetFrame is deprecated. Use the Frame property instead.")]
        public void SetFrame(int frame)
        {
            NativeCalls.godot_icall_1_4(method_bind_9, Object.GetPtr(this), frame);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frame");

        [GodotMethod("get_frame")]
        [Obsolete("GetFrame is deprecated. Use the Frame property instead.")]
        public int GetFrame()
        {
            return NativeCalls.godot_icall_0_5(method_bind_10, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
