using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Plays a sound effect with directed sound effects, dampens with distance if needed, generates effect of hearable position in space. For greater realism, a low-pass filter is automatically applied to distant sounds. This can be disabled by setting <see cref="Godot.AudioStreamPlayer3D.AttenuationFilterCutoffHz"/> to <c>20500</c>.</para>
    /// <para>By default, audio is heard from the camera position. This can be changed by adding a <see cref="Godot.Listener"/> node to the scene and enabling it by calling <see cref="Godot.Listener.MakeCurrent"/> on it.</para>
    /// <para>See also <see cref="Godot.AudioStreamPlayer"/> to play a sound non-positionally.</para>
    /// <para>Note: Hiding an <see cref="Godot.AudioStreamPlayer3D"/> node does not disable its audio output. To temporarily disable an <see cref="Godot.AudioStreamPlayer3D"/>'s audio output, set <see cref="Godot.AudioStreamPlayer3D.UnitDb"/> to a very low value like <c>-100</c> (which isn't audible to human hearing).</para>
    /// </summary>
    public partial class AudioStreamPlayer3D : Spatial
    {
        public enum AttenuationModelEnum
        {
            /// <summary>
            /// <para>Linear dampening of loudness according to distance.</para>
            /// </summary>
            InverseDistance = 0,
            /// <summary>
            /// <para>Squared dampening of loudness according to distance.</para>
            /// </summary>
            InverseSquareDistance = 1,
            /// <summary>
            /// <para>Logarithmic dampening of loudness according to distance.</para>
            /// </summary>
            Logarithmic = 2,
            /// <summary>
            /// <para>No dampening of loudness according to distance. The sound will still be heard positionally, unlike an <see cref="Godot.AudioStreamPlayer"/>. <see cref="Godot.AudioStreamPlayer3D.AttenuationModelEnum.Disabled"/> can be combined with a <see cref="Godot.AudioStreamPlayer3D.MaxDistance"/> value greater than <c>0.0</c> to achieve linear attenuation clamped to a sphere of a defined size.</para>
            /// </summary>
            Disabled = 3
        }

        public enum OutOfRangeModeEnum
        {
            /// <summary>
            /// <para>Mix this audio in, even when it's out of range. This increases CPU usage, but keeps the sound playing at the correct position if the camera leaves and enters the <see cref="Godot.AudioStreamPlayer3D"/>'s <see cref="Godot.AudioStreamPlayer3D.MaxDistance"/> radius.</para>
            /// </summary>
            Mix = 0,
            /// <summary>
            /// <para>Pause this audio when it gets out of range. This decreases CPU usage, but will cause the sound to restart if the camera leaves and enters the <see cref="Godot.AudioStreamPlayer3D"/>'s <see cref="Godot.AudioStreamPlayer3D.MaxDistance"/> radius.</para>
            /// </summary>
            Pause = 1
        }

        public enum DopplerTrackingEnum
        {
            /// <summary>
            /// <para>Disables doppler tracking.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Executes doppler tracking in idle step (every rendered frame).</para>
            /// </summary>
            IdleStep = 1,
            /// <summary>
            /// <para>Executes doppler tracking in physics step (every simulated physics frame).</para>
            /// </summary>
            PhysicsStep = 2
        }

        /// <summary>
        /// <para>The <see cref="Godot.AudioStream"/> resource to be played.</para>
        /// </summary>
        public AudioStream Stream
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStream();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStream(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Decides if audio should get quieter with distance linearly, quadratically, logarithmically, or not be affected by distance, effectively disabling attenuation.</para>
        /// </summary>
        public AudioStreamPlayer3D.AttenuationModelEnum AttenuationModel
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAttenuationModel();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAttenuationModel(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The base sound level unaffected by dampening, in decibels.</para>
        /// </summary>
        public float UnitDb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUnitDb();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUnitDb(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The factor for the attenuation effect. Higher values make the sound audible over a larger distance.</para>
        /// </summary>
        public float UnitSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUnitSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUnitSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the absolute maximum of the soundlevel, in decibels.</para>
        /// </summary>
        public float MaxDb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxDb();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxDb(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The pitch and the tempo of the audio, as a multiplier of the audio sample's sample rate.</para>
        /// </summary>
        public float PitchScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPitchScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPitchScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, audio is playing.</para>
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
                _SetPlaying(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, audio plays when the AudioStreamPlayer3D node is added to scene tree.</para>
        /// </summary>
        public bool Autoplay
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsAutoplayEnabled();
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
        /// <para>If <c>true</c>, the playback is paused. You can resume it by setting <see cref="Godot.AudioStreamPlayer3D.StreamPaused"/> to <c>false</c>.</para>
        /// </summary>
        public bool StreamPaused
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStreamPaused();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStreamPaused(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the distance from which the <see cref="Godot.AudioStreamPlayer3D.OutOfRangeMode"/> takes effect. Has no effect if set to 0.</para>
        /// </summary>
        public float MaxDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxDistance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxDistance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Decides if audio should pause when source is outside of <see cref="Godot.AudioStreamPlayer3D.MaxDistance"/> range.</para>
        /// </summary>
        public AudioStreamPlayer3D.OutOfRangeModeEnum OutOfRangeMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOutOfRangeMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOutOfRangeMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The bus on which this audio is playing.</para>
        /// <para>Note: When setting this property, keep in mind that no validation is performed to see if the given name matches an existing bus. This is because audio bus layouts might be loaded after this property is set. If this given name can't be resolved at runtime, it will fall back to <c>"Master"</c>.</para>
        /// </summary>
        public string Bus
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBus();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBus(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Determines which <see cref="Godot.Area"/> layers affect the sound for reverb and audio bus effects. Areas can be used to redirect <see cref="Godot.AudioStream"/>s so that they play in a certain audio bus. An example of how you might use this is making a "water" area so that sounds played in the water are redirected through an audio bus to make them sound like they are being played underwater.</para>
        /// </summary>
        public uint AreaMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAreaMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAreaMask(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the audio should be dampened according to the direction of the sound.</para>
        /// </summary>
        public bool EmissionAngleEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEmissionAngleEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionAngleEnabled(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The angle in which the audio reaches cameras undampened.</para>
        /// </summary>
        public float EmissionAngleDegrees
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionAngle();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionAngle(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Dampens audio if camera is outside of <see cref="Godot.AudioStreamPlayer3D.EmissionAngleDegrees"/> and <see cref="Godot.AudioStreamPlayer3D.EmissionAngleEnabled"/> is set by this factor, in decibels.</para>
        /// </summary>
        public float EmissionAngleFilterAttenuationDb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionAngleFilterAttenuationDb();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionAngleFilterAttenuationDb(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Dampens audio using a low-pass filter above this frequency, in Hz. To disable the dampening effect entirely, set this to <c>20500</c> as this frequency is above the human hearing limit.</para>
        /// </summary>
        public float AttenuationFilterCutoffHz
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAttenuationFilterCutoffHz();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAttenuationFilterCutoffHz(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Amount how much the filter affects the loudness, in decibels.</para>
        /// </summary>
        public float AttenuationFilterDb
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAttenuationFilterDb();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAttenuationFilterDb(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Decides in which step the <a href="https://en.wikipedia.org/wiki/Doppler_effect">Doppler effect</a> should be calculated.</para>
        /// <para>Note: Only effective if the current <see cref="Godot.Camera"/>'s <see cref="Godot.Camera.DopplerTracking"/> property is set to a value other than <see cref="Godot.Camera.DopplerTrackingEnum.Disabled"/>.</para>
        /// </summary>
        public AudioStreamPlayer3D.DopplerTrackingEnum DopplerTracking
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDopplerTracking();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDopplerTracking(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioStreamPlayer3D";

        public AudioStreamPlayer3D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioStreamPlayer3D_Ctor(this);
        }

        internal AudioStreamPlayer3D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stream");

        [GodotMethod("set_stream")]
        [Obsolete("SetStream is deprecated. Use the Stream property instead.")]
        public void SetStream(AudioStream stream)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(stream));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stream");

        [GodotMethod("get_stream")]
        [Obsolete("GetStream is deprecated. Use the Stream property instead.")]
        public AudioStream GetStream()
        {
            return NativeCalls.godot_icall_0_184(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_unit_db");

        [GodotMethod("set_unit_db")]
        [Obsolete("SetUnitDb is deprecated. Use the UnitDb property instead.")]
        public void SetUnitDb(float unitDb)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), unitDb);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_unit_db");

        [GodotMethod("get_unit_db")]
        [Obsolete("GetUnitDb is deprecated. Use the UnitDb property instead.")]
        public float GetUnitDb()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_unit_size");

        [GodotMethod("set_unit_size")]
        [Obsolete("SetUnitSize is deprecated. Use the UnitSize property instead.")]
        public void SetUnitSize(float unitSize)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), unitSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_unit_size");

        [GodotMethod("get_unit_size")]
        [Obsolete("GetUnitSize is deprecated. Use the UnitSize property instead.")]
        public float GetUnitSize()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_db");

        [GodotMethod("set_max_db")]
        [Obsolete("SetMaxDb is deprecated. Use the MaxDb property instead.")]
        public void SetMaxDb(float maxDb)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), maxDb);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_db");

        [GodotMethod("get_max_db")]
        [Obsolete("GetMaxDb is deprecated. Use the MaxDb property instead.")]
        public float GetMaxDb()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pitch_scale");

        [GodotMethod("set_pitch_scale")]
        [Obsolete("SetPitchScale is deprecated. Use the PitchScale property instead.")]
        public void SetPitchScale(float pitchScale)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), pitchScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pitch_scale");

        [GodotMethod("get_pitch_scale")]
        [Obsolete("GetPitchScale is deprecated. Use the PitchScale property instead.")]
        public float GetPitchScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "play");

        /// <summary>
        /// <para>Plays the audio from the given position <c>from_position</c>, in seconds.</para>
        /// </summary>
        [GodotMethod("play")]
        public void Play(float fromPosition = 0f)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), fromPosition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "seek");

        /// <summary>
        /// <para>Sets the position from which audio will be played, in seconds.</para>
        /// </summary>
        [GodotMethod("seek")]
        public void Seek(float toPosition)
        {
            NativeCalls.godot_icall_1_15(method_bind_11, Object.GetPtr(this), toPosition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "stop");

        /// <summary>
        /// <para>Stops the audio.</para>
        /// </summary>
        [GodotMethod("stop")]
        public void Stop()
        {
            NativeCalls.godot_icall_0_3(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_playing");

        [GodotMethod("is_playing")]
        [Obsolete("IsPlaying is deprecated. Use the Playing property instead.")]
        public bool IsPlaying()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_playback_position");

        /// <summary>
        /// <para>Returns the position in the <see cref="Godot.AudioStream"/>.</para>
        /// </summary>
        [GodotMethod("get_playback_position")]
        public float GetPlaybackPosition()
        {
            return NativeCalls.godot_icall_0_14(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bus");

        [GodotMethod("set_bus")]
        [Obsolete("SetBus is deprecated. Use the Bus property instead.")]
        public void SetBus(string bus)
        {
            NativeCalls.godot_icall_1_54(method_bind_15, Object.GetPtr(this), bus);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bus");

        [GodotMethod("get_bus")]
        [Obsolete("GetBus is deprecated. Use the Bus property instead.")]
        public string GetBus()
        {
            return NativeCalls.godot_icall_0_6(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_autoplay");

        [GodotMethod("set_autoplay")]
        [Obsolete("SetAutoplay is deprecated. Use the Autoplay property instead.")]
        public void SetAutoplay(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_17, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_autoplay_enabled");

        [GodotMethod("is_autoplay_enabled")]
        [Obsolete("IsAutoplayEnabled is deprecated. Use the Autoplay property instead.")]
        public bool IsAutoplayEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_playing");

        [Obsolete("_SetPlaying is deprecated. Use the Playing property instead.")]
        internal void _SetPlaying(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_19, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_distance");

        [GodotMethod("set_max_distance")]
        [Obsolete("SetMaxDistance is deprecated. Use the MaxDistance property instead.")]
        public void SetMaxDistance(float metres)
        {
            NativeCalls.godot_icall_1_15(method_bind_20, Object.GetPtr(this), metres);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_distance");

        [GodotMethod("get_max_distance")]
        [Obsolete("GetMaxDistance is deprecated. Use the MaxDistance property instead.")]
        public float GetMaxDistance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_area_mask");

        [GodotMethod("set_area_mask")]
        [Obsolete("SetAreaMask is deprecated. Use the AreaMask property instead.")]
        public void SetAreaMask(uint mask)
        {
            NativeCalls.godot_icall_1_187(method_bind_22, Object.GetPtr(this), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_area_mask");

        [GodotMethod("get_area_mask")]
        [Obsolete("GetAreaMask is deprecated. Use the AreaMask property instead.")]
        public uint GetAreaMask()
        {
            return NativeCalls.godot_icall_0_188(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_angle");

        [GodotMethod("set_emission_angle")]
        [Obsolete("SetEmissionAngle is deprecated. Use the EmissionAngleDegrees property instead.")]
        public void SetEmissionAngle(float degrees)
        {
            NativeCalls.godot_icall_1_15(method_bind_24, Object.GetPtr(this), degrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_angle");

        [GodotMethod("get_emission_angle")]
        [Obsolete("GetEmissionAngle is deprecated. Use the EmissionAngleDegrees property instead.")]
        public float GetEmissionAngle()
        {
            return NativeCalls.godot_icall_0_14(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_angle_enabled");

        [GodotMethod("set_emission_angle_enabled")]
        [Obsolete("SetEmissionAngleEnabled is deprecated. Use the EmissionAngleEnabled property instead.")]
        public void SetEmissionAngleEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_26, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_emission_angle_enabled");

        [GodotMethod("is_emission_angle_enabled")]
        [Obsolete("IsEmissionAngleEnabled is deprecated. Use the EmissionAngleEnabled property instead.")]
        public bool IsEmissionAngleEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_angle_filter_attenuation_db");

        [GodotMethod("set_emission_angle_filter_attenuation_db")]
        [Obsolete("SetEmissionAngleFilterAttenuationDb is deprecated. Use the EmissionAngleFilterAttenuationDb property instead.")]
        public void SetEmissionAngleFilterAttenuationDb(float db)
        {
            NativeCalls.godot_icall_1_15(method_bind_28, Object.GetPtr(this), db);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_angle_filter_attenuation_db");

        [GodotMethod("get_emission_angle_filter_attenuation_db")]
        [Obsolete("GetEmissionAngleFilterAttenuationDb is deprecated. Use the EmissionAngleFilterAttenuationDb property instead.")]
        public float GetEmissionAngleFilterAttenuationDb()
        {
            return NativeCalls.godot_icall_0_14(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_attenuation_filter_cutoff_hz");

        [GodotMethod("set_attenuation_filter_cutoff_hz")]
        [Obsolete("SetAttenuationFilterCutoffHz is deprecated. Use the AttenuationFilterCutoffHz property instead.")]
        public void SetAttenuationFilterCutoffHz(float degrees)
        {
            NativeCalls.godot_icall_1_15(method_bind_30, Object.GetPtr(this), degrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_attenuation_filter_cutoff_hz");

        [GodotMethod("get_attenuation_filter_cutoff_hz")]
        [Obsolete("GetAttenuationFilterCutoffHz is deprecated. Use the AttenuationFilterCutoffHz property instead.")]
        public float GetAttenuationFilterCutoffHz()
        {
            return NativeCalls.godot_icall_0_14(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_attenuation_filter_db");

        [GodotMethod("set_attenuation_filter_db")]
        [Obsolete("SetAttenuationFilterDb is deprecated. Use the AttenuationFilterDb property instead.")]
        public void SetAttenuationFilterDb(float db)
        {
            NativeCalls.godot_icall_1_15(method_bind_32, Object.GetPtr(this), db);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_attenuation_filter_db");

        [GodotMethod("get_attenuation_filter_db")]
        [Obsolete("GetAttenuationFilterDb is deprecated. Use the AttenuationFilterDb property instead.")]
        public float GetAttenuationFilterDb()
        {
            return NativeCalls.godot_icall_0_14(method_bind_33, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_attenuation_model");

        [GodotMethod("set_attenuation_model")]
        [Obsolete("SetAttenuationModel is deprecated. Use the AttenuationModel property instead.")]
        public void SetAttenuationModel(AudioStreamPlayer3D.AttenuationModelEnum model)
        {
            NativeCalls.godot_icall_1_4(method_bind_34, Object.GetPtr(this), (int)model);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_attenuation_model");

        [GodotMethod("get_attenuation_model")]
        [Obsolete("GetAttenuationModel is deprecated. Use the AttenuationModel property instead.")]
        public AudioStreamPlayer3D.AttenuationModelEnum GetAttenuationModel()
        {
            return (AudioStreamPlayer3D.AttenuationModelEnum)NativeCalls.godot_icall_0_189(method_bind_35, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_out_of_range_mode");

        [GodotMethod("set_out_of_range_mode")]
        [Obsolete("SetOutOfRangeMode is deprecated. Use the OutOfRangeMode property instead.")]
        public void SetOutOfRangeMode(AudioStreamPlayer3D.OutOfRangeModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_36, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_out_of_range_mode");

        [GodotMethod("get_out_of_range_mode")]
        [Obsolete("GetOutOfRangeMode is deprecated. Use the OutOfRangeMode property instead.")]
        public AudioStreamPlayer3D.OutOfRangeModeEnum GetOutOfRangeMode()
        {
            return (AudioStreamPlayer3D.OutOfRangeModeEnum)NativeCalls.godot_icall_0_190(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_doppler_tracking");

        [GodotMethod("set_doppler_tracking")]
        [Obsolete("SetDopplerTracking is deprecated. Use the DopplerTracking property instead.")]
        public void SetDopplerTracking(AudioStreamPlayer3D.DopplerTrackingEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_38, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_doppler_tracking");

        [GodotMethod("get_doppler_tracking")]
        [Obsolete("GetDopplerTracking is deprecated. Use the DopplerTracking property instead.")]
        public AudioStreamPlayer3D.DopplerTrackingEnum GetDopplerTracking()
        {
            return (AudioStreamPlayer3D.DopplerTrackingEnum)NativeCalls.godot_icall_0_191(method_bind_39, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stream_paused");

        [GodotMethod("set_stream_paused")]
        [Obsolete("SetStreamPaused is deprecated. Use the StreamPaused property instead.")]
        public void SetStreamPaused(bool pause)
        {
            NativeCalls.godot_icall_1_16(method_bind_40, Object.GetPtr(this), pause);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stream_paused");

        [GodotMethod("get_stream_paused")]
        [Obsolete("GetStreamPaused is deprecated. Use the StreamPaused property instead.")]
        public bool GetStreamPaused()
        {
            return NativeCalls.godot_icall_0_7(method_bind_41, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stream_playback");

        /// <summary>
        /// <para>Returns the <see cref="Godot.AudioStreamPlayback"/> object associated with this <see cref="Godot.AudioStreamPlayer3D"/>.</para>
        /// </summary>
        [GodotMethod("get_stream_playback")]
        public AudioStreamPlayback GetStreamPlayback()
        {
            return NativeCalls.godot_icall_0_186(method_bind_42, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
