using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A Spotlight is a type of <see cref="Godot.Light"/> node that emits lights in a specific direction, in the shape of a cone. The light is attenuated through the distance. This attenuation can be configured by changing the energy, radius and attenuation parameters of <see cref="Godot.Light"/>.</para>
    /// <para>Note: By default, only 32 SpotLights may affect a single mesh resource at once. Consider splitting your level into several meshes to decrease the likelihood that more than 32 lights will affect the same mesh resource. Splitting the level mesh will also improve frustum culling effectiveness, leading to greater performance. If you need to use more lights per mesh, you can increase  at the cost of shader compilation times.</para>
    /// </summary>
    public partial class SpotLight : Light
    {
        /// <summary>
        /// <para>The maximal range that can be reached by the spotlight. Note that the effectively lit area may appear to be smaller depending on the <see cref="Godot.SpotLight.SpotAttenuation"/> in use. No matter the <see cref="Godot.SpotLight.SpotAttenuation"/> in use, the light will never reach anything outside this range.</para>
        /// <para>Note: <see cref="Godot.SpotLight.SpotRange"/> is not affected by <see cref="Godot.Spatial.Scale"/> (the light's scale or its parent's scale).</para>
        /// </summary>
        public float SpotRange
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The spotlight's light energy attenuation curve.</para>
        /// </summary>
        public float SpotAttenuation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The spotlight's angle in degrees.</para>
        /// <para>Note: <see cref="Godot.SpotLight.SpotAngle"/> is not affected by <see cref="Godot.Spatial.Scale"/> (the light's scale or its parent's scale).</para>
        /// </summary>
        public float SpotAngle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)6, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The spotlight's angular attenuation curve.</para>
        /// </summary>
        public float SpotAngleAttenuation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((Light.Param)7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((Light.Param)7, value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "SpotLight";

        public SpotLight() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SpotLight_Ctor(this);
        }

        internal SpotLight(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
