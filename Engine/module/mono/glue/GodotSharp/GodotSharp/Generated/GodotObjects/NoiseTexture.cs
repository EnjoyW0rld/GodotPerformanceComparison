using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Uses an <see cref="Godot.OpenSimplexNoise"/> to fill the texture data. You can specify the texture size but keep in mind that larger textures will take longer to generate and seamless noise only works with square sized textures.</para>
    /// <para>NoiseTexture can also generate normalmap textures.</para>
    /// <para>The class uses <see cref="Godot.Thread"/>s to generate the texture data internally, so <see cref="Godot.Texture.GetData"/> may return <c>null</c> if the generation process has not completed yet. In that case, you need to wait for the texture to be generated before accessing the data:</para>
    /// <para><code>
    /// var texture = preload("res://noise.tres")
    /// yield(texture, "changed")
    /// var image = texture.get_data()
    /// </code></para>
    /// </summary>
    public partial class NoiseTexture : Texture
    {
        /// <summary>
        /// <para>Width of the generated texture.</para>
        /// </summary>
        public int Width
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWidth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWidth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Height of the generated texture.</para>
        /// </summary>
        public int Height
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHeight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHeight(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Whether the texture can be tiled without visible seams or not. Seamless textures take longer to generate.</para>
        /// <para>Note: Seamless noise has a lower contrast compared to non-seamless noise. This is due to the way noise uses higher dimensions for generating seamless noise.</para>
        /// </summary>
        public bool Seamless
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSeamless();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSeamless(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the resulting texture contains a normal map created from the original noise interpreted as a bump map.</para>
        /// </summary>
        public bool AsNormalmap
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsNormalmap();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAsNormalmap(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Strength of the bump maps used in this texture. A higher value will make the bump maps appear larger while a lower value will make them appear softer.</para>
        /// </summary>
        public float BumpStrength
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBumpStrength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBumpStrength(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.OpenSimplexNoise"/> instance used to generate the noise.</para>
        /// </summary>
        public OpenSimplexNoise Noise
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNoise();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNoise(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>An offset used to specify the noise space coordinate of the top left corner of the generated noise. This value is ignored if <see cref="Godot.NoiseTexture.Seamless"/> is enabled.</para>
        /// </summary>
        public Vector2 NoiseOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNoiseOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNoiseOffset(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "NoiseTexture";

        public NoiseTexture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_NoiseTexture_Ctor(this);
        }

        internal NoiseTexture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_width");

        [GodotMethod("set_width")]
        [Obsolete("SetWidth is deprecated. Use the Width property instead.")]
        public void SetWidth(int width)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), width);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_height");

        [GodotMethod("set_height")]
        [Obsolete("SetHeight is deprecated. Use the Height property instead.")]
        public void SetHeight(int height)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_noise");

        [GodotMethod("set_noise")]
        [Obsolete("SetNoise is deprecated. Use the Noise property instead.")]
        public void SetNoise(OpenSimplexNoise noise)
        {
            NativeCalls.godot_icall_1_24(method_bind_2, Object.GetPtr(this), Object.GetPtr(noise));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_noise");

        [GodotMethod("get_noise")]
        [Obsolete("GetNoise is deprecated. Use the Noise property instead.")]
        public OpenSimplexNoise GetNoise()
        {
            return NativeCalls.godot_icall_0_689(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_noise_offset");

        [GodotMethod("set_noise_offset")]
        [Obsolete("SetNoiseOffset is deprecated. Use the NoiseOffset property instead.")]
        public void SetNoiseOffset(Vector2 noiseOffset)
        {
            NativeCalls.godot_icall_1_57(method_bind_4, Object.GetPtr(this), ref noiseOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_noise_offset");

        [GodotMethod("get_noise_offset")]
        [Obsolete("GetNoiseOffset is deprecated. Use the NoiseOffset property instead.")]
        public Vector2 GetNoiseOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_5, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_seamless");

        [GodotMethod("set_seamless")]
        [Obsolete("SetSeamless is deprecated. Use the Seamless property instead.")]
        public void SetSeamless(bool seamless)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), seamless);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_seamless");

        [GodotMethod("get_seamless")]
        [Obsolete("GetSeamless is deprecated. Use the Seamless property instead.")]
        public bool GetSeamless()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_as_normalmap");

        [GodotMethod("set_as_normalmap")]
        [Obsolete("SetAsNormalmap is deprecated. Use the AsNormalmap property instead.")]
        public void SetAsNormalmap(bool asNormalmap)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), asNormalmap);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_normalmap");

        [GodotMethod("is_normalmap")]
        [Obsolete("IsNormalmap is deprecated. Use the AsNormalmap property instead.")]
        public bool IsNormalmap()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bump_strength");

        [GodotMethod("set_bump_strength")]
        [Obsolete("SetBumpStrength is deprecated. Use the BumpStrength property instead.")]
        public void SetBumpStrength(float bumpStrength)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), bumpStrength);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bump_strength");

        [GodotMethod("get_bump_strength")]
        [Obsolete("GetBumpStrength is deprecated. Use the BumpStrength property instead.")]
        public float GetBumpStrength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
