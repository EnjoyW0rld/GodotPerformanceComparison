using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>ProceduralSky provides a way to create an effective background quickly by defining procedural parameters for the sun, the sky and the ground. The sky and ground are very similar, they are defined by a color at the horizon, another color, and finally an easing curve to interpolate between these two colors. Similarly, the sun is described by a position in the sky, a color, and an easing curve. However, the sun also defines a minimum and maximum angle, these two values define at what distance the easing curve begins and ends from the sun, and thus end up defining the size of the sun in the sky.</para>
    /// <para>The ProceduralSky is updated on the CPU after the parameters change. It is stored in a texture and then displayed as a background in the scene. This makes it relatively unsuitable for real-time updates during gameplay. However, with a small enough texture size, it can still be updated relatively frequently, as it is updated on a background thread when multi-threading is available.</para>
    /// </summary>
    public partial class ProceduralSky : Sky
    {
        public enum TextureSizeEnum
        {
            /// <summary>
            /// <para>Sky texture will be 256x128.</para>
            /// </summary>
            Size256 = 0,
            /// <summary>
            /// <para>Sky texture will be 512x256.</para>
            /// </summary>
            Size512 = 1,
            /// <summary>
            /// <para>Sky texture will be 1024x512. This is the default size.</para>
            /// </summary>
            Size1024 = 2,
            /// <summary>
            /// <para>Sky texture will be 2048x1024.</para>
            /// </summary>
            Size2048 = 3,
            /// <summary>
            /// <para>Sky texture will be 4096x2048.</para>
            /// </summary>
            Size4096 = 4,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.ProceduralSky.TextureSizeEnum"/> enum.</para>
            /// </summary>
            Max = 5
        }

        /// <summary>
        /// <para>Color of the sky at the top.</para>
        /// </summary>
        public Color SkyTopColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkyTopColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkyTopColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Color of the sky at the horizon.</para>
        /// </summary>
        public Color SkyHorizonColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkyHorizonColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkyHorizonColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>How quickly the <see cref="Godot.ProceduralSky.SkyHorizonColor"/> fades into the <see cref="Godot.ProceduralSky.SkyTopColor"/>.</para>
        /// </summary>
        public float SkyCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkyCurve();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkyCurve(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Amount of energy contribution from the sky.</para>
        /// </summary>
        public float SkyEnergy
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkyEnergy();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkyEnergy(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Color of the ground at the bottom.</para>
        /// </summary>
        public Color GroundBottomColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGroundBottomColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGroundBottomColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Color of the ground at the horizon.</para>
        /// </summary>
        public Color GroundHorizonColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGroundHorizonColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGroundHorizonColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>How quickly the <see cref="Godot.ProceduralSky.GroundHorizonColor"/> fades into the <see cref="Godot.ProceduralSky.GroundBottomColor"/>.</para>
        /// </summary>
        public float GroundCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGroundCurve();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGroundCurve(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Amount of energy contribution from the ground.</para>
        /// </summary>
        public float GroundEnergy
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGroundEnergy();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGroundEnergy(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The sun's color.</para>
        /// </summary>
        public Color SunColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSunColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSunColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The sun's height using polar coordinates.</para>
        /// </summary>
        public float SunLatitude
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSunLatitude();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSunLatitude(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The direction of the sun using polar coordinates.</para>
        /// </summary>
        public float SunLongitude
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSunLongitude();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSunLongitude(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Distance from sun where it goes from solid to starting to fade.</para>
        /// </summary>
        public float SunAngleMin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSunAngleMin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSunAngleMin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Distance from center of sun where it fades out completely.</para>
        /// </summary>
        public float SunAngleMax
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSunAngleMax();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSunAngleMax(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>How quickly the sun fades away between <see cref="Godot.ProceduralSky.SunAngleMin"/> and <see cref="Godot.ProceduralSky.SunAngleMax"/>.</para>
        /// </summary>
        public float SunCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSunCurve();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSunCurve(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Amount of energy contribution from the sun.</para>
        /// </summary>
        public float SunEnergy
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSunEnergy();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSunEnergy(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Size of <see cref="Godot.Texture"/> that the ProceduralSky will generate. The size is set using <see cref="Godot.ProceduralSky.TextureSizeEnum"/>.</para>
        /// </summary>
        public ProceduralSky.TextureSizeEnum TextureSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTextureSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTextureSize(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ProceduralSky";

        public ProceduralSky() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ProceduralSky_Ctor(this);
        }

        internal ProceduralSky(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sky_top_color");

        [GodotMethod("set_sky_top_color")]
        [Obsolete("SetSkyTopColor is deprecated. Use the SkyTopColor property instead.")]
        public void SetSkyTopColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_0, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sky_top_color");

        [GodotMethod("get_sky_top_color")]
        [Obsolete("GetSkyTopColor is deprecated. Use the SkyTopColor property instead.")]
        public Color GetSkyTopColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_1, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sky_horizon_color");

        [GodotMethod("set_sky_horizon_color")]
        [Obsolete("SetSkyHorizonColor is deprecated. Use the SkyHorizonColor property instead.")]
        public void SetSkyHorizonColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_2, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sky_horizon_color");

        [GodotMethod("get_sky_horizon_color")]
        [Obsolete("GetSkyHorizonColor is deprecated. Use the SkyHorizonColor property instead.")]
        public Color GetSkyHorizonColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_3, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sky_curve");

        [GodotMethod("set_sky_curve")]
        [Obsolete("SetSkyCurve is deprecated. Use the SkyCurve property instead.")]
        public void SetSkyCurve(float curve)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), curve);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sky_curve");

        [GodotMethod("get_sky_curve")]
        [Obsolete("GetSkyCurve is deprecated. Use the SkyCurve property instead.")]
        public float GetSkyCurve()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sky_energy");

        [GodotMethod("set_sky_energy")]
        [Obsolete("SetSkyEnergy is deprecated. Use the SkyEnergy property instead.")]
        public void SetSkyEnergy(float energy)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), energy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sky_energy");

        [GodotMethod("get_sky_energy")]
        [Obsolete("GetSkyEnergy is deprecated. Use the SkyEnergy property instead.")]
        public float GetSkyEnergy()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ground_bottom_color");

        [GodotMethod("set_ground_bottom_color")]
        [Obsolete("SetGroundBottomColor is deprecated. Use the GroundBottomColor property instead.")]
        public void SetGroundBottomColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_8, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ground_bottom_color");

        [GodotMethod("get_ground_bottom_color")]
        [Obsolete("GetGroundBottomColor is deprecated. Use the GroundBottomColor property instead.")]
        public Color GetGroundBottomColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_9, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ground_horizon_color");

        [GodotMethod("set_ground_horizon_color")]
        [Obsolete("SetGroundHorizonColor is deprecated. Use the GroundHorizonColor property instead.")]
        public void SetGroundHorizonColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_10, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ground_horizon_color");

        [GodotMethod("get_ground_horizon_color")]
        [Obsolete("GetGroundHorizonColor is deprecated. Use the GroundHorizonColor property instead.")]
        public Color GetGroundHorizonColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_11, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ground_curve");

        [GodotMethod("set_ground_curve")]
        [Obsolete("SetGroundCurve is deprecated. Use the GroundCurve property instead.")]
        public void SetGroundCurve(float curve)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), curve);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ground_curve");

        [GodotMethod("get_ground_curve")]
        [Obsolete("GetGroundCurve is deprecated. Use the GroundCurve property instead.")]
        public float GetGroundCurve()
        {
            return NativeCalls.godot_icall_0_14(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ground_energy");

        [GodotMethod("set_ground_energy")]
        [Obsolete("SetGroundEnergy is deprecated. Use the GroundEnergy property instead.")]
        public void SetGroundEnergy(float energy)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), energy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ground_energy");

        [GodotMethod("get_ground_energy")]
        [Obsolete("GetGroundEnergy is deprecated. Use the GroundEnergy property instead.")]
        public float GetGroundEnergy()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sun_color");

        [GodotMethod("set_sun_color")]
        [Obsolete("SetSunColor is deprecated. Use the SunColor property instead.")]
        public void SetSunColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_16, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sun_color");

        [GodotMethod("get_sun_color")]
        [Obsolete("GetSunColor is deprecated. Use the SunColor property instead.")]
        public Color GetSunColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_17, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sun_latitude");

        [GodotMethod("set_sun_latitude")]
        [Obsolete("SetSunLatitude is deprecated. Use the SunLatitude property instead.")]
        public void SetSunLatitude(float degrees)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), degrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sun_latitude");

        [GodotMethod("get_sun_latitude")]
        [Obsolete("GetSunLatitude is deprecated. Use the SunLatitude property instead.")]
        public float GetSunLatitude()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sun_longitude");

        [GodotMethod("set_sun_longitude")]
        [Obsolete("SetSunLongitude is deprecated. Use the SunLongitude property instead.")]
        public void SetSunLongitude(float degrees)
        {
            NativeCalls.godot_icall_1_15(method_bind_20, Object.GetPtr(this), degrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sun_longitude");

        [GodotMethod("get_sun_longitude")]
        [Obsolete("GetSunLongitude is deprecated. Use the SunLongitude property instead.")]
        public float GetSunLongitude()
        {
            return NativeCalls.godot_icall_0_14(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sun_angle_min");

        [GodotMethod("set_sun_angle_min")]
        [Obsolete("SetSunAngleMin is deprecated. Use the SunAngleMin property instead.")]
        public void SetSunAngleMin(float degrees)
        {
            NativeCalls.godot_icall_1_15(method_bind_22, Object.GetPtr(this), degrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sun_angle_min");

        [GodotMethod("get_sun_angle_min")]
        [Obsolete("GetSunAngleMin is deprecated. Use the SunAngleMin property instead.")]
        public float GetSunAngleMin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sun_angle_max");

        [GodotMethod("set_sun_angle_max")]
        [Obsolete("SetSunAngleMax is deprecated. Use the SunAngleMax property instead.")]
        public void SetSunAngleMax(float degrees)
        {
            NativeCalls.godot_icall_1_15(method_bind_24, Object.GetPtr(this), degrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sun_angle_max");

        [GodotMethod("get_sun_angle_max")]
        [Obsolete("GetSunAngleMax is deprecated. Use the SunAngleMax property instead.")]
        public float GetSunAngleMax()
        {
            return NativeCalls.godot_icall_0_14(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sun_curve");

        [GodotMethod("set_sun_curve")]
        [Obsolete("SetSunCurve is deprecated. Use the SunCurve property instead.")]
        public void SetSunCurve(float curve)
        {
            NativeCalls.godot_icall_1_15(method_bind_26, Object.GetPtr(this), curve);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sun_curve");

        [GodotMethod("get_sun_curve")]
        [Obsolete("GetSunCurve is deprecated. Use the SunCurve property instead.")]
        public float GetSunCurve()
        {
            return NativeCalls.godot_icall_0_14(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sun_energy");

        [GodotMethod("set_sun_energy")]
        [Obsolete("SetSunEnergy is deprecated. Use the SunEnergy property instead.")]
        public void SetSunEnergy(float energy)
        {
            NativeCalls.godot_icall_1_15(method_bind_28, Object.GetPtr(this), energy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sun_energy");

        [GodotMethod("get_sun_energy")]
        [Obsolete("GetSunEnergy is deprecated. Use the SunEnergy property instead.")]
        public float GetSunEnergy()
        {
            return NativeCalls.godot_icall_0_14(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture_size");

        [GodotMethod("set_texture_size")]
        [Obsolete("SetTextureSize is deprecated. Use the TextureSize property instead.")]
        public void SetTextureSize(ProceduralSky.TextureSizeEnum size)
        {
            NativeCalls.godot_icall_1_4(method_bind_30, Object.GetPtr(this), (int)size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture_size");

        [GodotMethod("get_texture_size")]
        [Obsolete("GetTextureSize is deprecated. Use the TextureSize property instead.")]
        public ProceduralSky.TextureSizeEnum GetTextureSize()
        {
            return (ProceduralSky.TextureSizeEnum)NativeCalls.godot_icall_0_807(method_bind_31, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
