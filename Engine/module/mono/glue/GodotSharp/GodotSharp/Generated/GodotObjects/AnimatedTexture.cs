using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.AnimatedTexture"/> is a resource format for frame-based animations, where multiple textures can be chained automatically with a predefined delay for each frame. Unlike <see cref="Godot.AnimationPlayer"/> or <see cref="Godot.AnimatedSprite"/>, it isn't a <see cref="Godot.Node"/>, but has the advantage of being usable anywhere a <see cref="Godot.Texture"/> resource can be used, e.g. in a <see cref="Godot.TileSet"/>.</para>
    /// <para>The playback of the animation is controlled by the <see cref="Godot.AnimatedTexture.Fps"/> property as well as each frame's optional delay (see <see cref="Godot.AnimatedTexture.SetFrameDelay"/>). The animation loops, i.e. it will restart at frame 0 automatically after playing the last frame.</para>
    /// <para><see cref="Godot.AnimatedTexture"/> currently requires all frame textures to have the same size, otherwise the bigger ones will be cropped to match the smallest one.</para>
    /// <para>Note: AnimatedTexture doesn't support using <see cref="Godot.AtlasTexture"/>s. Each frame needs to be a separate <see cref="Godot.Texture"/>.</para>
    /// </summary>
    public partial class AnimatedTexture : Texture
    {
        /// <summary>
        /// <para>The maximum number of frames supported by <see cref="Godot.AnimatedTexture"/>. If you need more frames in your animation, use <see cref="Godot.AnimationPlayer"/> or <see cref="Godot.AnimatedSprite"/>.</para>
        /// </summary>
        public const int MaxFrames = 256;

        /// <summary>
        /// <para>Number of frames to use in the animation. While you can create the frames independently with <see cref="Godot.AnimatedTexture.SetFrameTexture"/>, you need to set this value for the animation to take new frames into account. The maximum number of frames is <see cref="Godot.AnimatedTexture.MaxFrames"/>.</para>
        /// </summary>
        public int Frames
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrames();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrames(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the currently visible frame of the texture.</para>
        /// </summary>
        public int CurrentFrame
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCurrentFrame();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCurrentFrame(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the animation will pause where it currently is (i.e. at <see cref="Godot.AnimatedTexture.CurrentFrame"/>). The animation will continue from where it was paused when changing this property to <c>false</c>.</para>
        /// </summary>
        public bool Pause
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPause();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPause(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the animation will only play once and will not loop back to the first frame after reaching the end. Note that reaching the end will not set <see cref="Godot.AnimatedTexture.Pause"/> to <c>true</c>.</para>
        /// </summary>
        public bool Oneshot
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOneshot();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOneshot(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Animation speed in frames per second. This value defines the default time interval between two frames of the animation, and thus the overall duration of the animation loop based on the <see cref="Godot.AnimatedTexture.Frames"/> property. A value of 0 means no predefined number of frames per second, the animation will play according to each frame's frame delay (see <see cref="Godot.AnimatedTexture.SetFrameDelay"/>).</para>
        /// <para>For example, an animation with 8 frames, no frame delay and a <c>fps</c> value of 2 will run for 4 seconds, with each frame lasting 0.5 seconds.</para>
        /// </summary>
        public float Fps
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFps();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFps(value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame0__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(0, value);
            }
#pragma warning restore CS0618
        }

        public float Frame0__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(0, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame1__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(1, value);
            }
#pragma warning restore CS0618
        }

        public float Frame1__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(1, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame2__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(2, value);
            }
#pragma warning restore CS0618
        }

        public float Frame2__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(2, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame3__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(3, value);
            }
#pragma warning restore CS0618
        }

        public float Frame3__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(3, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame4__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(4, value);
            }
#pragma warning restore CS0618
        }

        public float Frame4__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(4, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame5__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(5, value);
            }
#pragma warning restore CS0618
        }

        public float Frame5__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(5, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame6__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(6, value);
            }
#pragma warning restore CS0618
        }

        public float Frame6__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(6, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame7__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(7, value);
            }
#pragma warning restore CS0618
        }

        public float Frame7__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(7, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame8__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(8, value);
            }
#pragma warning restore CS0618
        }

        public float Frame8__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(8, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame9__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(9, value);
            }
#pragma warning restore CS0618
        }

        public float Frame9__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(9, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame10__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(10, value);
            }
#pragma warning restore CS0618
        }

        public float Frame10__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(10, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame11__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(11);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(11, value);
            }
#pragma warning restore CS0618
        }

        public float Frame11__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(11);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(11, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame12__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(12);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(12, value);
            }
#pragma warning restore CS0618
        }

        public float Frame12__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(12);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(12, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame13__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(13);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(13, value);
            }
#pragma warning restore CS0618
        }

        public float Frame13__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(13);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(13, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame14__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(14);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(14, value);
            }
#pragma warning restore CS0618
        }

        public float Frame14__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(14);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(14, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame15__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(15);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(15, value);
            }
#pragma warning restore CS0618
        }

        public float Frame15__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(15);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(15, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame16__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(16);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(16, value);
            }
#pragma warning restore CS0618
        }

        public float Frame16__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(16);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(16, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame17__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(17);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(17, value);
            }
#pragma warning restore CS0618
        }

        public float Frame17__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(17);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(17, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame18__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(18);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(18, value);
            }
#pragma warning restore CS0618
        }

        public float Frame18__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(18);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(18, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame19__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(19);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(19, value);
            }
#pragma warning restore CS0618
        }

        public float Frame19__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(19);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(19, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame20__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(20);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(20, value);
            }
#pragma warning restore CS0618
        }

        public float Frame20__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(20);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(20, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame21__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(21);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(21, value);
            }
#pragma warning restore CS0618
        }

        public float Frame21__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(21);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(21, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame22__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(22);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(22, value);
            }
#pragma warning restore CS0618
        }

        public float Frame22__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(22);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(22, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame23__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(23);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(23, value);
            }
#pragma warning restore CS0618
        }

        public float Frame23__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(23);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(23, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame24__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(24);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(24, value);
            }
#pragma warning restore CS0618
        }

        public float Frame24__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(24);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(24, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame25__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(25);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(25, value);
            }
#pragma warning restore CS0618
        }

        public float Frame25__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(25);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(25, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame26__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(26);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(26, value);
            }
#pragma warning restore CS0618
        }

        public float Frame26__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(26);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(26, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame27__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(27);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(27, value);
            }
#pragma warning restore CS0618
        }

        public float Frame27__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(27);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(27, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame28__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(28);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(28, value);
            }
#pragma warning restore CS0618
        }

        public float Frame28__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(28);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(28, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame29__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(29);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(29, value);
            }
#pragma warning restore CS0618
        }

        public float Frame29__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(29);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(29, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame30__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(30);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(30, value);
            }
#pragma warning restore CS0618
        }

        public float Frame30__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(30);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(30, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame31__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(31);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(31, value);
            }
#pragma warning restore CS0618
        }

        public float Frame31__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(31);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(31, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame32__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(32);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(32, value);
            }
#pragma warning restore CS0618
        }

        public float Frame32__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(32);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(32, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame33__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(33);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(33, value);
            }
#pragma warning restore CS0618
        }

        public float Frame33__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(33);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(33, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame34__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(34);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(34, value);
            }
#pragma warning restore CS0618
        }

        public float Frame34__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(34);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(34, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame35__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(35);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(35, value);
            }
#pragma warning restore CS0618
        }

        public float Frame35__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(35);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(35, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame36__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(36);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(36, value);
            }
#pragma warning restore CS0618
        }

        public float Frame36__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(36);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(36, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame37__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(37);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(37, value);
            }
#pragma warning restore CS0618
        }

        public float Frame37__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(37);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(37, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame38__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(38);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(38, value);
            }
#pragma warning restore CS0618
        }

        public float Frame38__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(38);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(38, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame39__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(39);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(39, value);
            }
#pragma warning restore CS0618
        }

        public float Frame39__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(39);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(39, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame40__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(40);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(40, value);
            }
#pragma warning restore CS0618
        }

        public float Frame40__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(40);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(40, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame41__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(41);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(41, value);
            }
#pragma warning restore CS0618
        }

        public float Frame41__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(41);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(41, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame42__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(42);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(42, value);
            }
#pragma warning restore CS0618
        }

        public float Frame42__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(42);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(42, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame43__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(43);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(43, value);
            }
#pragma warning restore CS0618
        }

        public float Frame43__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(43);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(43, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame44__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(44);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(44, value);
            }
#pragma warning restore CS0618
        }

        public float Frame44__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(44);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(44, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame45__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(45);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(45, value);
            }
#pragma warning restore CS0618
        }

        public float Frame45__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(45);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(45, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame46__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(46);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(46, value);
            }
#pragma warning restore CS0618
        }

        public float Frame46__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(46);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(46, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame47__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(47);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(47, value);
            }
#pragma warning restore CS0618
        }

        public float Frame47__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(47);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(47, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame48__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(48);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(48, value);
            }
#pragma warning restore CS0618
        }

        public float Frame48__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(48);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(48, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame49__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(49);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(49, value);
            }
#pragma warning restore CS0618
        }

        public float Frame49__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(49);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(49, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame50__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(50);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(50, value);
            }
#pragma warning restore CS0618
        }

        public float Frame50__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(50);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(50, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame51__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(51);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(51, value);
            }
#pragma warning restore CS0618
        }

        public float Frame51__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(51);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(51, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame52__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(52);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(52, value);
            }
#pragma warning restore CS0618
        }

        public float Frame52__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(52);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(52, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame53__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(53);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(53, value);
            }
#pragma warning restore CS0618
        }

        public float Frame53__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(53);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(53, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame54__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(54);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(54, value);
            }
#pragma warning restore CS0618
        }

        public float Frame54__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(54);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(54, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame55__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(55);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(55, value);
            }
#pragma warning restore CS0618
        }

        public float Frame55__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(55);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(55, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame56__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(56);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(56, value);
            }
#pragma warning restore CS0618
        }

        public float Frame56__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(56);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(56, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame57__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(57);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(57, value);
            }
#pragma warning restore CS0618
        }

        public float Frame57__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(57);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(57, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame58__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(58);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(58, value);
            }
#pragma warning restore CS0618
        }

        public float Frame58__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(58);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(58, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame59__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(59);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(59, value);
            }
#pragma warning restore CS0618
        }

        public float Frame59__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(59);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(59, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame60__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(60);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(60, value);
            }
#pragma warning restore CS0618
        }

        public float Frame60__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(60);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(60, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame61__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(61);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(61, value);
            }
#pragma warning restore CS0618
        }

        public float Frame61__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(61);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(61, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame62__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(62);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(62, value);
            }
#pragma warning restore CS0618
        }

        public float Frame62__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(62);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(62, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame63__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(63);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(63, value);
            }
#pragma warning restore CS0618
        }

        public float Frame63__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(63);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(63, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame64__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(64);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(64, value);
            }
#pragma warning restore CS0618
        }

        public float Frame64__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(64);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(64, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame65__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(65);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(65, value);
            }
#pragma warning restore CS0618
        }

        public float Frame65__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(65);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(65, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame66__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(66);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(66, value);
            }
#pragma warning restore CS0618
        }

        public float Frame66__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(66);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(66, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame67__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(67);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(67, value);
            }
#pragma warning restore CS0618
        }

        public float Frame67__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(67);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(67, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame68__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(68);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(68, value);
            }
#pragma warning restore CS0618
        }

        public float Frame68__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(68);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(68, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame69__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(69);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(69, value);
            }
#pragma warning restore CS0618
        }

        public float Frame69__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(69);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(69, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame70__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(70);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(70, value);
            }
#pragma warning restore CS0618
        }

        public float Frame70__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(70);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(70, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame71__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(71);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(71, value);
            }
#pragma warning restore CS0618
        }

        public float Frame71__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(71);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(71, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame72__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(72);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(72, value);
            }
#pragma warning restore CS0618
        }

        public float Frame72__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(72);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(72, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame73__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(73);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(73, value);
            }
#pragma warning restore CS0618
        }

        public float Frame73__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(73);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(73, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame74__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(74);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(74, value);
            }
#pragma warning restore CS0618
        }

        public float Frame74__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(74);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(74, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame75__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(75);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(75, value);
            }
#pragma warning restore CS0618
        }

        public float Frame75__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(75);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(75, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame76__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(76);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(76, value);
            }
#pragma warning restore CS0618
        }

        public float Frame76__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(76);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(76, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame77__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(77);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(77, value);
            }
#pragma warning restore CS0618
        }

        public float Frame77__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(77);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(77, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame78__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(78);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(78, value);
            }
#pragma warning restore CS0618
        }

        public float Frame78__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(78);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(78, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame79__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(79);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(79, value);
            }
#pragma warning restore CS0618
        }

        public float Frame79__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(79);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(79, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame80__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(80);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(80, value);
            }
#pragma warning restore CS0618
        }

        public float Frame80__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(80);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(80, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame81__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(81);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(81, value);
            }
#pragma warning restore CS0618
        }

        public float Frame81__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(81);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(81, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame82__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(82);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(82, value);
            }
#pragma warning restore CS0618
        }

        public float Frame82__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(82);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(82, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame83__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(83);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(83, value);
            }
#pragma warning restore CS0618
        }

        public float Frame83__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(83);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(83, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame84__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(84);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(84, value);
            }
#pragma warning restore CS0618
        }

        public float Frame84__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(84);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(84, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame85__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(85);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(85, value);
            }
#pragma warning restore CS0618
        }

        public float Frame85__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(85);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(85, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame86__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(86);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(86, value);
            }
#pragma warning restore CS0618
        }

        public float Frame86__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(86);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(86, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame87__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(87);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(87, value);
            }
#pragma warning restore CS0618
        }

        public float Frame87__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(87);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(87, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame88__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(88);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(88, value);
            }
#pragma warning restore CS0618
        }

        public float Frame88__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(88);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(88, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame89__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(89);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(89, value);
            }
#pragma warning restore CS0618
        }

        public float Frame89__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(89);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(89, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame90__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(90);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(90, value);
            }
#pragma warning restore CS0618
        }

        public float Frame90__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(90);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(90, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame91__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(91);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(91, value);
            }
#pragma warning restore CS0618
        }

        public float Frame91__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(91);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(91, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame92__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(92);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(92, value);
            }
#pragma warning restore CS0618
        }

        public float Frame92__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(92);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(92, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame93__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(93);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(93, value);
            }
#pragma warning restore CS0618
        }

        public float Frame93__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(93);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(93, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame94__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(94);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(94, value);
            }
#pragma warning restore CS0618
        }

        public float Frame94__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(94);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(94, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame95__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(95);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(95, value);
            }
#pragma warning restore CS0618
        }

        public float Frame95__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(95);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(95, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame96__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(96);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(96, value);
            }
#pragma warning restore CS0618
        }

        public float Frame96__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(96);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(96, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame97__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(97);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(97, value);
            }
#pragma warning restore CS0618
        }

        public float Frame97__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(97);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(97, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame98__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(98);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(98, value);
            }
#pragma warning restore CS0618
        }

        public float Frame98__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(98);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(98, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame99__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(99);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(99, value);
            }
#pragma warning restore CS0618
        }

        public float Frame99__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(99);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(99, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame100__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(100);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(100, value);
            }
#pragma warning restore CS0618
        }

        public float Frame100__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(100);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(100, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame101__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(101);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(101, value);
            }
#pragma warning restore CS0618
        }

        public float Frame101__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(101);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(101, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame102__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(102);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(102, value);
            }
#pragma warning restore CS0618
        }

        public float Frame102__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(102);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(102, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame103__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(103);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(103, value);
            }
#pragma warning restore CS0618
        }

        public float Frame103__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(103);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(103, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame104__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(104);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(104, value);
            }
#pragma warning restore CS0618
        }

        public float Frame104__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(104);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(104, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame105__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(105);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(105, value);
            }
#pragma warning restore CS0618
        }

        public float Frame105__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(105);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(105, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame106__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(106);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(106, value);
            }
#pragma warning restore CS0618
        }

        public float Frame106__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(106);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(106, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame107__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(107);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(107, value);
            }
#pragma warning restore CS0618
        }

        public float Frame107__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(107);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(107, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame108__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(108);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(108, value);
            }
#pragma warning restore CS0618
        }

        public float Frame108__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(108);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(108, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame109__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(109);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(109, value);
            }
#pragma warning restore CS0618
        }

        public float Frame109__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(109);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(109, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame110__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(110);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(110, value);
            }
#pragma warning restore CS0618
        }

        public float Frame110__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(110);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(110, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame111__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(111);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(111, value);
            }
#pragma warning restore CS0618
        }

        public float Frame111__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(111);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(111, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame112__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(112);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(112, value);
            }
#pragma warning restore CS0618
        }

        public float Frame112__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(112);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(112, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame113__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(113);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(113, value);
            }
#pragma warning restore CS0618
        }

        public float Frame113__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(113);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(113, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame114__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(114);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(114, value);
            }
#pragma warning restore CS0618
        }

        public float Frame114__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(114);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(114, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame115__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(115);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(115, value);
            }
#pragma warning restore CS0618
        }

        public float Frame115__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(115);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(115, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame116__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(116);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(116, value);
            }
#pragma warning restore CS0618
        }

        public float Frame116__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(116);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(116, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame117__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(117);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(117, value);
            }
#pragma warning restore CS0618
        }

        public float Frame117__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(117);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(117, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame118__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(118);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(118, value);
            }
#pragma warning restore CS0618
        }

        public float Frame118__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(118);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(118, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame119__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(119);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(119, value);
            }
#pragma warning restore CS0618
        }

        public float Frame119__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(119);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(119, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame120__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(120);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(120, value);
            }
#pragma warning restore CS0618
        }

        public float Frame120__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(120);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(120, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame121__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(121);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(121, value);
            }
#pragma warning restore CS0618
        }

        public float Frame121__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(121);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(121, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame122__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(122);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(122, value);
            }
#pragma warning restore CS0618
        }

        public float Frame122__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(122);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(122, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame123__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(123);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(123, value);
            }
#pragma warning restore CS0618
        }

        public float Frame123__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(123);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(123, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame124__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(124);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(124, value);
            }
#pragma warning restore CS0618
        }

        public float Frame124__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(124);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(124, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame125__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(125);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(125, value);
            }
#pragma warning restore CS0618
        }

        public float Frame125__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(125);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(125, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame126__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(126);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(126, value);
            }
#pragma warning restore CS0618
        }

        public float Frame126__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(126);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(126, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame127__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(127);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(127, value);
            }
#pragma warning restore CS0618
        }

        public float Frame127__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(127);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(127, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame128__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(128);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(128, value);
            }
#pragma warning restore CS0618
        }

        public float Frame128__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(128);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(128, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame129__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(129);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(129, value);
            }
#pragma warning restore CS0618
        }

        public float Frame129__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(129);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(129, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame130__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(130);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(130, value);
            }
#pragma warning restore CS0618
        }

        public float Frame130__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(130);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(130, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame131__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(131);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(131, value);
            }
#pragma warning restore CS0618
        }

        public float Frame131__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(131);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(131, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame132__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(132);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(132, value);
            }
#pragma warning restore CS0618
        }

        public float Frame132__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(132);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(132, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame133__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(133);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(133, value);
            }
#pragma warning restore CS0618
        }

        public float Frame133__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(133);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(133, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame134__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(134);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(134, value);
            }
#pragma warning restore CS0618
        }

        public float Frame134__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(134);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(134, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame135__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(135);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(135, value);
            }
#pragma warning restore CS0618
        }

        public float Frame135__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(135);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(135, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame136__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(136);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(136, value);
            }
#pragma warning restore CS0618
        }

        public float Frame136__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(136);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(136, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame137__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(137);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(137, value);
            }
#pragma warning restore CS0618
        }

        public float Frame137__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(137);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(137, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame138__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(138);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(138, value);
            }
#pragma warning restore CS0618
        }

        public float Frame138__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(138);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(138, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame139__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(139);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(139, value);
            }
#pragma warning restore CS0618
        }

        public float Frame139__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(139);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(139, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame140__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(140);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(140, value);
            }
#pragma warning restore CS0618
        }

        public float Frame140__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(140);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(140, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame141__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(141);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(141, value);
            }
#pragma warning restore CS0618
        }

        public float Frame141__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(141);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(141, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame142__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(142);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(142, value);
            }
#pragma warning restore CS0618
        }

        public float Frame142__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(142);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(142, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame143__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(143);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(143, value);
            }
#pragma warning restore CS0618
        }

        public float Frame143__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(143);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(143, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame144__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(144);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(144, value);
            }
#pragma warning restore CS0618
        }

        public float Frame144__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(144);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(144, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame145__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(145);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(145, value);
            }
#pragma warning restore CS0618
        }

        public float Frame145__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(145);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(145, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame146__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(146);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(146, value);
            }
#pragma warning restore CS0618
        }

        public float Frame146__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(146);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(146, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame147__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(147);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(147, value);
            }
#pragma warning restore CS0618
        }

        public float Frame147__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(147);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(147, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame148__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(148);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(148, value);
            }
#pragma warning restore CS0618
        }

        public float Frame148__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(148);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(148, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame149__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(149);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(149, value);
            }
#pragma warning restore CS0618
        }

        public float Frame149__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(149);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(149, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame150__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(150);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(150, value);
            }
#pragma warning restore CS0618
        }

        public float Frame150__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(150);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(150, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame151__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(151);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(151, value);
            }
#pragma warning restore CS0618
        }

        public float Frame151__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(151);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(151, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame152__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(152);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(152, value);
            }
#pragma warning restore CS0618
        }

        public float Frame152__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(152);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(152, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame153__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(153);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(153, value);
            }
#pragma warning restore CS0618
        }

        public float Frame153__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(153);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(153, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame154__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(154);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(154, value);
            }
#pragma warning restore CS0618
        }

        public float Frame154__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(154);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(154, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame155__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(155);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(155, value);
            }
#pragma warning restore CS0618
        }

        public float Frame155__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(155);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(155, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame156__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(156);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(156, value);
            }
#pragma warning restore CS0618
        }

        public float Frame156__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(156);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(156, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame157__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(157);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(157, value);
            }
#pragma warning restore CS0618
        }

        public float Frame157__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(157);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(157, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame158__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(158);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(158, value);
            }
#pragma warning restore CS0618
        }

        public float Frame158__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(158);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(158, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame159__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(159);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(159, value);
            }
#pragma warning restore CS0618
        }

        public float Frame159__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(159);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(159, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame160__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(160);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(160, value);
            }
#pragma warning restore CS0618
        }

        public float Frame160__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(160);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(160, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame161__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(161);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(161, value);
            }
#pragma warning restore CS0618
        }

        public float Frame161__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(161);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(161, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame162__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(162);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(162, value);
            }
#pragma warning restore CS0618
        }

        public float Frame162__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(162);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(162, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame163__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(163);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(163, value);
            }
#pragma warning restore CS0618
        }

        public float Frame163__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(163);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(163, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame164__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(164);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(164, value);
            }
#pragma warning restore CS0618
        }

        public float Frame164__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(164);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(164, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame165__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(165);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(165, value);
            }
#pragma warning restore CS0618
        }

        public float Frame165__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(165);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(165, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame166__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(166);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(166, value);
            }
#pragma warning restore CS0618
        }

        public float Frame166__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(166);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(166, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame167__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(167);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(167, value);
            }
#pragma warning restore CS0618
        }

        public float Frame167__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(167);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(167, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame168__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(168);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(168, value);
            }
#pragma warning restore CS0618
        }

        public float Frame168__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(168);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(168, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame169__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(169);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(169, value);
            }
#pragma warning restore CS0618
        }

        public float Frame169__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(169);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(169, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame170__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(170);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(170, value);
            }
#pragma warning restore CS0618
        }

        public float Frame170__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(170);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(170, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame171__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(171);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(171, value);
            }
#pragma warning restore CS0618
        }

        public float Frame171__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(171);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(171, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame172__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(172);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(172, value);
            }
#pragma warning restore CS0618
        }

        public float Frame172__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(172);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(172, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame173__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(173);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(173, value);
            }
#pragma warning restore CS0618
        }

        public float Frame173__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(173);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(173, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame174__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(174);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(174, value);
            }
#pragma warning restore CS0618
        }

        public float Frame174__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(174);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(174, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame175__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(175);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(175, value);
            }
#pragma warning restore CS0618
        }

        public float Frame175__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(175);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(175, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame176__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(176);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(176, value);
            }
#pragma warning restore CS0618
        }

        public float Frame176__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(176);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(176, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame177__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(177);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(177, value);
            }
#pragma warning restore CS0618
        }

        public float Frame177__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(177);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(177, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame178__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(178);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(178, value);
            }
#pragma warning restore CS0618
        }

        public float Frame178__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(178);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(178, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame179__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(179);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(179, value);
            }
#pragma warning restore CS0618
        }

        public float Frame179__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(179);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(179, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame180__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(180);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(180, value);
            }
#pragma warning restore CS0618
        }

        public float Frame180__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(180);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(180, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame181__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(181);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(181, value);
            }
#pragma warning restore CS0618
        }

        public float Frame181__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(181);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(181, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame182__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(182);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(182, value);
            }
#pragma warning restore CS0618
        }

        public float Frame182__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(182);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(182, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame183__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(183);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(183, value);
            }
#pragma warning restore CS0618
        }

        public float Frame183__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(183);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(183, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame184__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(184);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(184, value);
            }
#pragma warning restore CS0618
        }

        public float Frame184__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(184);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(184, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame185__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(185);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(185, value);
            }
#pragma warning restore CS0618
        }

        public float Frame185__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(185);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(185, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame186__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(186);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(186, value);
            }
#pragma warning restore CS0618
        }

        public float Frame186__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(186);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(186, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame187__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(187);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(187, value);
            }
#pragma warning restore CS0618
        }

        public float Frame187__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(187);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(187, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame188__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(188);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(188, value);
            }
#pragma warning restore CS0618
        }

        public float Frame188__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(188);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(188, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame189__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(189);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(189, value);
            }
#pragma warning restore CS0618
        }

        public float Frame189__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(189);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(189, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame190__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(190);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(190, value);
            }
#pragma warning restore CS0618
        }

        public float Frame190__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(190);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(190, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame191__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(191);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(191, value);
            }
#pragma warning restore CS0618
        }

        public float Frame191__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(191);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(191, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame192__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(192);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(192, value);
            }
#pragma warning restore CS0618
        }

        public float Frame192__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(192);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(192, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame193__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(193);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(193, value);
            }
#pragma warning restore CS0618
        }

        public float Frame193__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(193);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(193, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame194__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(194);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(194, value);
            }
#pragma warning restore CS0618
        }

        public float Frame194__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(194);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(194, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame195__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(195);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(195, value);
            }
#pragma warning restore CS0618
        }

        public float Frame195__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(195);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(195, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame196__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(196);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(196, value);
            }
#pragma warning restore CS0618
        }

        public float Frame196__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(196);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(196, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame197__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(197);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(197, value);
            }
#pragma warning restore CS0618
        }

        public float Frame197__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(197);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(197, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame198__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(198);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(198, value);
            }
#pragma warning restore CS0618
        }

        public float Frame198__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(198);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(198, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame199__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(199);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(199, value);
            }
#pragma warning restore CS0618
        }

        public float Frame199__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(199);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(199, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame200__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(200);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(200, value);
            }
#pragma warning restore CS0618
        }

        public float Frame200__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(200);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(200, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame201__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(201);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(201, value);
            }
#pragma warning restore CS0618
        }

        public float Frame201__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(201);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(201, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame202__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(202);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(202, value);
            }
#pragma warning restore CS0618
        }

        public float Frame202__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(202);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(202, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame203__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(203);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(203, value);
            }
#pragma warning restore CS0618
        }

        public float Frame203__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(203);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(203, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame204__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(204);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(204, value);
            }
#pragma warning restore CS0618
        }

        public float Frame204__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(204);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(204, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame205__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(205);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(205, value);
            }
#pragma warning restore CS0618
        }

        public float Frame205__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(205);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(205, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame206__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(206);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(206, value);
            }
#pragma warning restore CS0618
        }

        public float Frame206__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(206);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(206, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame207__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(207);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(207, value);
            }
#pragma warning restore CS0618
        }

        public float Frame207__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(207);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(207, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame208__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(208);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(208, value);
            }
#pragma warning restore CS0618
        }

        public float Frame208__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(208);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(208, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame209__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(209);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(209, value);
            }
#pragma warning restore CS0618
        }

        public float Frame209__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(209);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(209, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame210__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(210);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(210, value);
            }
#pragma warning restore CS0618
        }

        public float Frame210__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(210);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(210, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame211__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(211);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(211, value);
            }
#pragma warning restore CS0618
        }

        public float Frame211__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(211);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(211, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame212__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(212);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(212, value);
            }
#pragma warning restore CS0618
        }

        public float Frame212__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(212);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(212, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame213__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(213);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(213, value);
            }
#pragma warning restore CS0618
        }

        public float Frame213__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(213);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(213, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame214__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(214);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(214, value);
            }
#pragma warning restore CS0618
        }

        public float Frame214__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(214);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(214, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame215__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(215);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(215, value);
            }
#pragma warning restore CS0618
        }

        public float Frame215__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(215);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(215, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame216__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(216);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(216, value);
            }
#pragma warning restore CS0618
        }

        public float Frame216__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(216);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(216, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame217__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(217);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(217, value);
            }
#pragma warning restore CS0618
        }

        public float Frame217__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(217);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(217, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame218__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(218);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(218, value);
            }
#pragma warning restore CS0618
        }

        public float Frame218__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(218);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(218, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame219__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(219);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(219, value);
            }
#pragma warning restore CS0618
        }

        public float Frame219__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(219);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(219, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame220__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(220);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(220, value);
            }
#pragma warning restore CS0618
        }

        public float Frame220__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(220);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(220, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame221__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(221);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(221, value);
            }
#pragma warning restore CS0618
        }

        public float Frame221__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(221);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(221, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame222__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(222);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(222, value);
            }
#pragma warning restore CS0618
        }

        public float Frame222__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(222);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(222, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame223__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(223);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(223, value);
            }
#pragma warning restore CS0618
        }

        public float Frame223__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(223);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(223, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame224__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(224);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(224, value);
            }
#pragma warning restore CS0618
        }

        public float Frame224__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(224);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(224, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame225__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(225);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(225, value);
            }
#pragma warning restore CS0618
        }

        public float Frame225__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(225);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(225, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame226__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(226);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(226, value);
            }
#pragma warning restore CS0618
        }

        public float Frame226__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(226);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(226, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame227__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(227);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(227, value);
            }
#pragma warning restore CS0618
        }

        public float Frame227__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(227);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(227, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame228__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(228);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(228, value);
            }
#pragma warning restore CS0618
        }

        public float Frame228__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(228);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(228, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame229__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(229);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(229, value);
            }
#pragma warning restore CS0618
        }

        public float Frame229__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(229);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(229, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame230__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(230);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(230, value);
            }
#pragma warning restore CS0618
        }

        public float Frame230__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(230);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(230, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame231__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(231);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(231, value);
            }
#pragma warning restore CS0618
        }

        public float Frame231__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(231);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(231, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame232__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(232);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(232, value);
            }
#pragma warning restore CS0618
        }

        public float Frame232__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(232);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(232, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame233__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(233);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(233, value);
            }
#pragma warning restore CS0618
        }

        public float Frame233__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(233);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(233, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame234__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(234);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(234, value);
            }
#pragma warning restore CS0618
        }

        public float Frame234__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(234);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(234, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame235__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(235);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(235, value);
            }
#pragma warning restore CS0618
        }

        public float Frame235__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(235);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(235, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame236__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(236);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(236, value);
            }
#pragma warning restore CS0618
        }

        public float Frame236__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(236);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(236, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame237__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(237);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(237, value);
            }
#pragma warning restore CS0618
        }

        public float Frame237__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(237);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(237, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame238__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(238);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(238, value);
            }
#pragma warning restore CS0618
        }

        public float Frame238__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(238);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(238, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame239__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(239);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(239, value);
            }
#pragma warning restore CS0618
        }

        public float Frame239__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(239);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(239, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame240__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(240);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(240, value);
            }
#pragma warning restore CS0618
        }

        public float Frame240__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(240);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(240, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame241__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(241);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(241, value);
            }
#pragma warning restore CS0618
        }

        public float Frame241__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(241);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(241, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame242__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(242);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(242, value);
            }
#pragma warning restore CS0618
        }

        public float Frame242__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(242);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(242, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame243__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(243);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(243, value);
            }
#pragma warning restore CS0618
        }

        public float Frame243__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(243);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(243, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame244__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(244);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(244, value);
            }
#pragma warning restore CS0618
        }

        public float Frame244__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(244);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(244, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame245__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(245);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(245, value);
            }
#pragma warning restore CS0618
        }

        public float Frame245__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(245);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(245, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame246__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(246);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(246, value);
            }
#pragma warning restore CS0618
        }

        public float Frame246__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(246);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(246, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame247__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(247);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(247, value);
            }
#pragma warning restore CS0618
        }

        public float Frame247__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(247);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(247, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame248__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(248);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(248, value);
            }
#pragma warning restore CS0618
        }

        public float Frame248__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(248);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(248, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame249__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(249);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(249, value);
            }
#pragma warning restore CS0618
        }

        public float Frame249__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(249);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(249, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame250__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(250);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(250, value);
            }
#pragma warning restore CS0618
        }

        public float Frame250__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(250);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(250, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame251__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(251);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(251, value);
            }
#pragma warning restore CS0618
        }

        public float Frame251__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(251);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(251, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame252__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(252);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(252, value);
            }
#pragma warning restore CS0618
        }

        public float Frame252__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(252);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(252, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame253__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(253);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(253, value);
            }
#pragma warning restore CS0618
        }

        public float Frame253__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(253);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(253, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame254__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(254);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(254, value);
            }
#pragma warning restore CS0618
        }

        public float Frame254__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(254);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(254, value);
            }
#pragma warning restore CS0618
        }

        public Texture Frame255__texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameTexture(255);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameTexture(255, value);
            }
#pragma warning restore CS0618
        }

        public float Frame255__delaySec
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameDelay(255);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameDelay(255, value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AnimatedTexture";

        public AnimatedTexture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimatedTexture_Ctor(this);
        }

        internal AnimatedTexture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_frames");

        [GodotMethod("set_frames")]
        [Obsolete("SetFrames is deprecated. Use the Frames property instead.")]
        public void SetFrames(int frames)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), frames);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frames");

        [GodotMethod("get_frames")]
        [Obsolete("GetFrames is deprecated. Use the Frames property instead.")]
        public int GetFrames()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_current_frame");

        [GodotMethod("set_current_frame")]
        [Obsolete("SetCurrentFrame is deprecated. Use the CurrentFrame property instead.")]
        public void SetCurrentFrame(int frame)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), frame);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_frame");

        [GodotMethod("get_current_frame")]
        [Obsolete("GetCurrentFrame is deprecated. Use the CurrentFrame property instead.")]
        public int GetCurrentFrame()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pause");

        [GodotMethod("set_pause")]
        [Obsolete("SetPause is deprecated. Use the Pause property instead.")]
        public void SetPause(bool pause)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), pause);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pause");

        [GodotMethod("get_pause")]
        [Obsolete("GetPause is deprecated. Use the Pause property instead.")]
        public bool GetPause()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_oneshot");

        [GodotMethod("set_oneshot")]
        [Obsolete("SetOneshot is deprecated. Use the Oneshot property instead.")]
        public void SetOneshot(bool oneshot)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), oneshot);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_oneshot");

        [GodotMethod("get_oneshot")]
        [Obsolete("GetOneshot is deprecated. Use the Oneshot property instead.")]
        public bool GetOneshot()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fps");

        [GodotMethod("set_fps")]
        [Obsolete("SetFps is deprecated. Use the Fps property instead.")]
        public void SetFps(float fps)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), fps);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fps");

        [GodotMethod("get_fps")]
        [Obsolete("GetFps is deprecated. Use the Fps property instead.")]
        public float GetFps()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_frame_texture");

        /// <summary>
        /// <para>Assigns a <see cref="Godot.Texture"/> to the given frame. Frame IDs start at 0, so the first frame has ID 0, and the last frame of the animation has ID <see cref="Godot.AnimatedTexture.Frames"/> - 1.</para>
        /// <para>You can define any number of textures up to <see cref="Godot.AnimatedTexture.MaxFrames"/>, but keep in mind that only frames from 0 to <see cref="Godot.AnimatedTexture.Frames"/> - 1 will be part of the animation.</para>
        /// </summary>
        [GodotMethod("set_frame_texture")]
        [Obsolete("SetFrameTexture is deprecated. Use the Frame255__texture property instead.")]
        public void SetFrameTexture(int frame, Texture texture)
        {
            NativeCalls.godot_icall_2_58(method_bind_10, Object.GetPtr(this), frame, Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frame_texture");

        /// <summary>
        /// <para>Returns the given frame's <see cref="Godot.Texture"/>.</para>
        /// </summary>
        [GodotMethod("get_frame_texture")]
        [Obsolete("GetFrameTexture is deprecated. Use the Frame255__texture property instead.")]
        public Texture GetFrameTexture(int frame)
        {
            return NativeCalls.godot_icall_1_59(method_bind_11, Object.GetPtr(this), frame);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_frame_delay");

        /// <summary>
        /// <para>Sets an additional delay (in seconds) between this frame and the next one, that will be added to the time interval defined by <see cref="Godot.AnimatedTexture.Fps"/>. By default, frames have no delay defined. If a delay value is defined, the final time interval between this frame and the next will be <c>1.0 / fps + delay</c>.</para>
        /// <para>For example, for an animation with 3 frames, 2 FPS and a frame delay on the second frame of 1.2, the resulting playback will be:</para>
        /// <para><code>
        /// Frame 0: 0.5 s (1 / fps)
        /// Frame 1: 1.7 s (1 / fps + 1.2)
        /// Frame 2: 0.5 s (1 / fps)
        /// Total duration: 2.7 s
        /// </code></para>
        /// </summary>
        [GodotMethod("set_frame_delay")]
        [Obsolete("SetFrameDelay is deprecated. Use the Frame255__delaySec property instead.")]
        public void SetFrameDelay(int frame, float delay)
        {
            NativeCalls.godot_icall_2_34(method_bind_12, Object.GetPtr(this), frame, delay);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frame_delay");

        /// <summary>
        /// <para>Returns the given frame's delay value.</para>
        /// </summary>
        [GodotMethod("get_frame_delay")]
        [Obsolete("GetFrameDelay is deprecated. Use the Frame255__delaySec property instead.")]
        public float GetFrameDelay(int frame)
        {
            return NativeCalls.godot_icall_1_12(method_bind_13, Object.GetPtr(this), frame);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
