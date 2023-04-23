using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.AnimatedSprite"/> is similar to the <see cref="Godot.Sprite"/> node, except it carries multiple textures as animation frames. Animations are created using a <see cref="Godot.SpriteFrames"/> resource, which allows you to import image files (or a folder containing said files) to provide the animation frames for the sprite. The <see cref="Godot.SpriteFrames"/> resource can be configured in the editor via the SpriteFrames bottom panel.</para>
    /// <para>Note: You can associate a set of normal or specular maps by creating additional <see cref="Godot.SpriteFrames"/> resources with a <c>_normal</c> or <c>_specular</c> suffix. For example, having 3 <see cref="Godot.SpriteFrames"/> resources <c>run</c>, <c>run_normal</c>, and <c>run_specular</c> will make it so the <c>run</c> animation uses normal and specular maps.</para>
    /// </summary>
    public partial class AnimatedSprite : Node2D
    {
        /// <summary>
        /// <para>The <see cref="Godot.SpriteFrames"/> resource containing the animation(s). Allows you the option to load, edit, clear, make unique and save the states of the <see cref="Godot.SpriteFrames"/> resource.</para>
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
        /// <para>The current animation from the <see cref="Godot.AnimatedSprite.Frames"/> resource. If this value changes, the <c>frame</c> counter is reset.</para>
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
        /// <para>The animation speed is multiplied by this value.</para>
        /// </summary>
        public float SpeedScale
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
        /// <para>If <c>true</c>, the <see cref="Godot.AnimatedSprite.Animation"/> is currently playing.</para>
        /// </summary>
        public bool Playing
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPlaying();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPlaying(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, texture will be centered.</para>
        /// </summary>
        public bool Centered
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsCentered();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCentered(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The texture's drawing offset.</para>
        /// </summary>
        public Vector2 Offset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, texture is flipped horizontally.</para>
        /// </summary>
        public bool FlipH
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFlippedH();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlipH(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, texture is flipped vertically.</para>
        /// </summary>
        public bool FlipV
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFlippedV();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlipV(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AnimatedSprite";

        public AnimatedSprite() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimatedSprite_Ctor(this);
        }

        internal AnimatedSprite(bool memoryOwn) : base(memoryOwn) {}

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
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_playing");

        [GodotMethod("set_playing")]
        [Obsolete("SetPlaying is deprecated. Use the Playing property instead.")]
        public void SetPlaying(bool playing)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), playing);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_playing");

        [GodotMethod("is_playing")]
        [Obsolete("IsPlaying is deprecated. Use the Playing property instead.")]
        public bool IsPlaying()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "play");

        /// <summary>
        /// <para>Plays the animation named <c>anim</c>. If no <c>anim</c> is provided, the current animation is played. If <c>backwards</c> is <c>true</c>, the animation will be played in reverse.</para>
        /// </summary>
        [GodotMethod("play")]
        public void Play(string anim = "", bool backwards = false)
        {
            NativeCalls.godot_icall_2_56(method_bind_6, Object.GetPtr(this), anim, backwards);
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
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_centered");

        [GodotMethod("set_centered")]
        [Obsolete("SetCentered is deprecated. Use the Centered property instead.")]
        public void SetCentered(bool centered)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), centered);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_centered");

        [GodotMethod("is_centered")]
        [Obsolete("IsCentered is deprecated. Use the Centered property instead.")]
        public bool IsCentered()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_offset");

        [GodotMethod("set_offset")]
        [Obsolete("SetOffset is deprecated. Use the Offset property instead.")]
        public void SetOffset(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_10, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_offset");

        [GodotMethod("get_offset")]
        [Obsolete("GetOffset is deprecated. Use the Offset property instead.")]
        public Vector2 GetOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_11, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flip_h");

        [GodotMethod("set_flip_h")]
        [Obsolete("SetFlipH is deprecated. Use the FlipH property instead.")]
        public void SetFlipH(bool flipH)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), flipH);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_flipped_h");

        [GodotMethod("is_flipped_h")]
        [Obsolete("IsFlippedH is deprecated. Use the FlipH property instead.")]
        public bool IsFlippedH()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flip_v");

        [GodotMethod("set_flip_v")]
        [Obsolete("SetFlipV is deprecated. Use the FlipV property instead.")]
        public void SetFlipV(bool flipV)
        {
            NativeCalls.godot_icall_1_16(method_bind_14, Object.GetPtr(this), flipV);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_flipped_v");

        [GodotMethod("is_flipped_v")]
        [Obsolete("IsFlippedV is deprecated. Use the FlipV property instead.")]
        public bool IsFlippedV()
        {
            return NativeCalls.godot_icall_0_7(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_frame");

        [GodotMethod("set_frame")]
        [Obsolete("SetFrame is deprecated. Use the Frame property instead.")]
        public void SetFrame(int frame)
        {
            NativeCalls.godot_icall_1_4(method_bind_16, Object.GetPtr(this), frame);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frame");

        [GodotMethod("get_frame")]
        [Obsolete("GetFrame is deprecated. Use the Frame property instead.")]
        public int GetFrame()
        {
            return NativeCalls.godot_icall_0_5(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_speed_scale");

        [GodotMethod("set_speed_scale")]
        [Obsolete("SetSpeedScale is deprecated. Use the SpeedScale property instead.")]
        public void SetSpeedScale(float speedScale)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), speedScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_speed_scale");

        [GodotMethod("get_speed_scale")]
        [Obsolete("GetSpeedScale is deprecated. Use the SpeedScale property instead.")]
        public float GetSpeedScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
