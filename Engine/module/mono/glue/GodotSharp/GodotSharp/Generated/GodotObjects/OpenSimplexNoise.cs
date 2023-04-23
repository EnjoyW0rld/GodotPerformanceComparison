using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This resource allows you to configure and sample a fractal noise space. Here is a brief usage example that configures an OpenSimplexNoise and gets samples at various positions and dimensions:</para>
    /// <para><code>
    /// var noise = OpenSimplexNoise.new()
    /// 
    /// # Configure
    /// noise.seed = randi()
    /// noise.octaves = 4
    /// noise.period = 20.0
    /// noise.persistence = 0.8
    /// 
    /// # Sample
    /// print("Values:")
    /// print(noise.get_noise_2d(1.0, 1.0))
    /// print(noise.get_noise_3d(0.5, 3.0, 15.0))
    /// print(noise.get_noise_4d(0.5, 1.9, 4.7, 0.0))
    /// </code></para>
    /// </summary>
    public partial class OpenSimplexNoise : Resource
    {
        /// <summary>
        /// <para>Seed used to generate random values, different seeds will generate different noise maps.</para>
        /// </summary>
        public int Seed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSeed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSeed(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Number of OpenSimplex noise layers that are sampled to get the fractal noise. Higher values result in more detailed noise but take more time to generate.</para>
        /// <para>Note: The maximum allowed value is 9.</para>
        /// </summary>
        public int Octaves
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOctaves();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOctaves(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Period of the base octave. A lower period results in a higher-frequency noise (more value changes across the same distance).</para>
        /// </summary>
        public float Period
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPeriod();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPeriod(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Contribution factor of the different octaves. A <c>persistence</c> value of 1 means all the octaves have the same contribution, a value of 0.5 means each octave contributes half as much as the previous one.</para>
        /// </summary>
        public float Persistence
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPersistence();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPersistence(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Difference in period between <see cref="Godot.OpenSimplexNoise.Octaves"/>.</para>
        /// </summary>
        public float Lacunarity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLacunarity();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLacunarity(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "OpenSimplexNoise";

        public OpenSimplexNoise() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_OpenSimplexNoise_Ctor(this);
        }

        internal OpenSimplexNoise(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_seed");

        [GodotMethod("get_seed")]
        [Obsolete("GetSeed is deprecated. Use the Seed property instead.")]
        public int GetSeed()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_seed");

        [GodotMethod("set_seed")]
        [Obsolete("SetSeed is deprecated. Use the Seed property instead.")]
        public void SetSeed(int seed)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), seed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_octaves");

        [GodotMethod("set_octaves")]
        [Obsolete("SetOctaves is deprecated. Use the Octaves property instead.")]
        public void SetOctaves(int octaveCount)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), octaveCount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_octaves");

        [GodotMethod("get_octaves")]
        [Obsolete("GetOctaves is deprecated. Use the Octaves property instead.")]
        public int GetOctaves()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_period");

        [GodotMethod("set_period")]
        [Obsolete("SetPeriod is deprecated. Use the Period property instead.")]
        public void SetPeriod(float period)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), period);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_period");

        [GodotMethod("get_period")]
        [Obsolete("GetPeriod is deprecated. Use the Period property instead.")]
        public float GetPeriod()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_persistence");

        [GodotMethod("set_persistence")]
        [Obsolete("SetPersistence is deprecated. Use the Persistence property instead.")]
        public void SetPersistence(float persistence)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), persistence);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_persistence");

        [GodotMethod("get_persistence")]
        [Obsolete("GetPersistence is deprecated. Use the Persistence property instead.")]
        public float GetPersistence()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_lacunarity");

        [GodotMethod("set_lacunarity")]
        [Obsolete("SetLacunarity is deprecated. Use the Lacunarity property instead.")]
        public void SetLacunarity(float lacunarity)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), lacunarity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_lacunarity");

        [GodotMethod("get_lacunarity")]
        [Obsolete("GetLacunarity is deprecated. Use the Lacunarity property instead.")]
        public float GetLacunarity()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_image");

        /// <summary>
        /// <para>Generate a noise image in <see cref="Godot.Image.Format.L8"/> format with the requested <c>width</c> and <c>height</c>, based on the current noise parameters. If <c>noise_offset</c> is specified, then the offset value is used as the coordinates of the top-left corner of the generated noise.</para>
        /// </summary>
        /// <param name="noiseOffset">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("get_image")]
        public Image GetImage(int width, int height, Nullable<Vector2> noiseOffset = null)
        {
            Vector2 noiseOffset_in = noiseOffset.HasValue ? noiseOffset.Value : new Vector2(0, 0);
            return NativeCalls.godot_icall_3_704(method_bind_10, Object.GetPtr(this), width, height, ref noiseOffset_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_seamless_image");

        /// <summary>
        /// <para>Generate a tileable noise image in <see cref="Godot.Image.Format.L8"/> format, based on the current noise parameters. Generated seamless images are always square (<c>size</c> × <c>size</c>).</para>
        /// <para>Note: Seamless noise has a lower contrast compared to non-seamless noise. This is due to the way noise uses higher dimensions for generating seamless noise.</para>
        /// </summary>
        [GodotMethod("get_seamless_image")]
        public Image GetSeamlessImage(int size)
        {
            return NativeCalls.godot_icall_1_339(method_bind_11, Object.GetPtr(this), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_noise_1d");

        /// <summary>
        /// <para>Returns the 1D noise value <c>[-1,1]</c> at the given x-coordinate.</para>
        /// <para>Note: This method actually returns the 2D noise value <c>[-1,1]</c> with fixed y-coordinate value 0.0.</para>
        /// </summary>
        [GodotMethod("get_noise_1d")]
        public float GetNoise1d(float x)
        {
            return NativeCalls.godot_icall_1_344(method_bind_12, Object.GetPtr(this), x);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_noise_2d");

        /// <summary>
        /// <para>Returns the 2D noise value <c>[-1,1]</c> at the given position.</para>
        /// </summary>
        [GodotMethod("get_noise_2d")]
        public float GetNoise2d(float x, float y)
        {
            return NativeCalls.godot_icall_2_705(method_bind_13, Object.GetPtr(this), x, y);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_noise_3d");

        /// <summary>
        /// <para>Returns the 3D noise value <c>[-1,1]</c> at the given position.</para>
        /// </summary>
        [GodotMethod("get_noise_3d")]
        public float GetNoise3d(float x, float y, float z)
        {
            return NativeCalls.godot_icall_3_706(method_bind_14, Object.GetPtr(this), x, y, z);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_noise_4d");

        /// <summary>
        /// <para>Returns the 4D noise value <c>[-1,1]</c> at the given position.</para>
        /// </summary>
        [GodotMethod("get_noise_4d")]
        public float GetNoise4d(float x, float y, float z, float w)
        {
            return NativeCalls.godot_icall_4_707(method_bind_15, Object.GetPtr(this), x, y, z, w);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_noise_2dv");

        /// <summary>
        /// <para>Returns the 2D noise value <c>[-1,1]</c> at the given position.</para>
        /// </summary>
        [GodotMethod("get_noise_2dv")]
        public float GetNoise2dv(Vector2 pos)
        {
            return NativeCalls.godot_icall_1_350(method_bind_16, Object.GetPtr(this), ref pos);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_noise_3dv");

        /// <summary>
        /// <para>Returns the 3D noise value <c>[-1,1]</c> at the given position.</para>
        /// </summary>
        [GodotMethod("get_noise_3dv")]
        public float GetNoise3dv(Vector3 pos)
        {
            return NativeCalls.godot_icall_1_357(method_bind_17, Object.GetPtr(this), ref pos);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
