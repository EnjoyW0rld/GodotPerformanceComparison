using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>ParticlesMaterial defines particle properties and behavior. It is used in the <c>process_material</c> of <see cref="Godot.Particles"/> and <see cref="Godot.Particles2D"/> emitter nodes.</para>
    /// <para>Some of this material's properties are applied to each particle when emitted, while others can have a <see cref="Godot.CurveTexture"/> applied to vary values over the lifetime of the particle.</para>
    /// <para>When a randomness ratio is applied to a property it is used to scale that property by a random amount. The random ratio is used to interpolate between <c>1.0</c> and a random number less than one, the result is multiplied by the property to obtain the randomized property. For example a random ratio of <c>0.4</c> would scale the original property between <c>0.4-1.0</c> of its original value.</para>
    /// </summary>
    public partial class ParticlesMaterial : Material
    {
        public enum Flags
        {
            /// <summary>
            /// <para>Use with <see cref="Godot.ParticlesMaterial.SetFlag"/> to set <see cref="Godot.ParticlesMaterial.FlagAlignY"/>.</para>
            /// </summary>
            AlignYToVelocity = 0,
            /// <summary>
            /// <para>Use with <see cref="Godot.ParticlesMaterial.SetFlag"/> to set <see cref="Godot.ParticlesMaterial.FlagRotateY"/>.</para>
            /// </summary>
            RotateY = 1,
            /// <summary>
            /// <para>Use with <see cref="Godot.ParticlesMaterial.SetFlag"/> to set <see cref="Godot.ParticlesMaterial.FlagDisableZ"/>.</para>
            /// </summary>
            DisableZ = 2,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.ParticlesMaterial.Flags"/> enum.</para>
            /// </summary>
            Max = 3
        }

        public enum EmissionShapeEnum
        {
            /// <summary>
            /// <para>All particles will be emitted from a single point.</para>
            /// </summary>
            Point = 0,
            /// <summary>
            /// <para>Particles will be emitted in the volume of a sphere.</para>
            /// </summary>
            Sphere = 1,
            /// <summary>
            /// <para>Particles will be emitted in the volume of a box.</para>
            /// </summary>
            Box = 2,
            /// <summary>
            /// <para>Particles will be emitted at a position determined by sampling a random point on the <see cref="Godot.ParticlesMaterial.EmissionPointTexture"/>. Particle color will be modulated by <see cref="Godot.ParticlesMaterial.EmissionColorTexture"/>.</para>
            /// </summary>
            Points = 3,
            /// <summary>
            /// <para>Particles will be emitted at a position determined by sampling a random point on the <see cref="Godot.ParticlesMaterial.EmissionPointTexture"/>. Particle velocity and rotation will be set based on <see cref="Godot.ParticlesMaterial.EmissionNormalTexture"/>. Particle color will be modulated by <see cref="Godot.ParticlesMaterial.EmissionColorTexture"/>.</para>
            /// </summary>
            DirectedPoints = 4,
            /// <summary>
            /// <para>Particles will be emitted in a ring or cylinder.</para>
            /// </summary>
            Ring = 5,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.ParticlesMaterial.EmissionShapeEnum"/> enum.</para>
            /// </summary>
            Max = 6
        }

        public enum Parameter
        {
            /// <summary>
            /// <para>Use with <see cref="Godot.ParticlesMaterial.SetParam"/>, <see cref="Godot.ParticlesMaterial.SetParamRandomness"/>, and <see cref="Godot.ParticlesMaterial.SetParamTexture"/> to set initial velocity properties.</para>
            /// </summary>
            InitialLinearVelocity = 0,
            /// <summary>
            /// <para>Use with <see cref="Godot.ParticlesMaterial.SetParam"/>, <see cref="Godot.ParticlesMaterial.SetParamRandomness"/>, and <see cref="Godot.ParticlesMaterial.SetParamTexture"/> to set angular velocity properties.</para>
            /// </summary>
            AngularVelocity = 1,
            /// <summary>
            /// <para>Use with <see cref="Godot.ParticlesMaterial.SetParam"/>, <see cref="Godot.ParticlesMaterial.SetParamRandomness"/>, and <see cref="Godot.ParticlesMaterial.SetParamTexture"/> to set orbital velocity properties.</para>
            /// </summary>
            OrbitVelocity = 2,
            /// <summary>
            /// <para>Use with <see cref="Godot.ParticlesMaterial.SetParam"/>, <see cref="Godot.ParticlesMaterial.SetParamRandomness"/>, and <see cref="Godot.ParticlesMaterial.SetParamTexture"/> to set linear acceleration properties.</para>
            /// </summary>
            LinearAccel = 3,
            /// <summary>
            /// <para>Use with <see cref="Godot.ParticlesMaterial.SetParam"/>, <see cref="Godot.ParticlesMaterial.SetParamRandomness"/>, and <see cref="Godot.ParticlesMaterial.SetParamTexture"/> to set radial acceleration properties.</para>
            /// </summary>
            RadialAccel = 4,
            /// <summary>
            /// <para>Use with <see cref="Godot.ParticlesMaterial.SetParam"/>, <see cref="Godot.ParticlesMaterial.SetParamRandomness"/>, and <see cref="Godot.ParticlesMaterial.SetParamTexture"/> to set tangential acceleration properties.</para>
            /// </summary>
            TangentialAccel = 5,
            /// <summary>
            /// <para>Use with <see cref="Godot.ParticlesMaterial.SetParam"/>, <see cref="Godot.ParticlesMaterial.SetParamRandomness"/>, and <see cref="Godot.ParticlesMaterial.SetParamTexture"/> to set damping properties.</para>
            /// </summary>
            Damping = 6,
            /// <summary>
            /// <para>Use with <see cref="Godot.ParticlesMaterial.SetParam"/>, <see cref="Godot.ParticlesMaterial.SetParamRandomness"/>, and <see cref="Godot.ParticlesMaterial.SetParamTexture"/> to set angle properties.</para>
            /// </summary>
            Angle = 7,
            /// <summary>
            /// <para>Use with <see cref="Godot.ParticlesMaterial.SetParam"/>, <see cref="Godot.ParticlesMaterial.SetParamRandomness"/>, and <see cref="Godot.ParticlesMaterial.SetParamTexture"/> to set scale properties.</para>
            /// </summary>
            Scale = 8,
            /// <summary>
            /// <para>Use with <see cref="Godot.ParticlesMaterial.SetParam"/>, <see cref="Godot.ParticlesMaterial.SetParamRandomness"/>, and <see cref="Godot.ParticlesMaterial.SetParamTexture"/> to set hue variation properties.</para>
            /// </summary>
            HueVariation = 9,
            /// <summary>
            /// <para>Use with <see cref="Godot.ParticlesMaterial.SetParam"/>, <see cref="Godot.ParticlesMaterial.SetParamRandomness"/>, and <see cref="Godot.ParticlesMaterial.SetParamTexture"/> to set animation speed properties.</para>
            /// </summary>
            AnimSpeed = 10,
            /// <summary>
            /// <para>Use with <see cref="Godot.ParticlesMaterial.SetParam"/>, <see cref="Godot.ParticlesMaterial.SetParamRandomness"/>, and <see cref="Godot.ParticlesMaterial.SetParamTexture"/> to set animation offset properties.</para>
            /// </summary>
            AnimOffset = 11,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.ParticlesMaterial.Parameter"/> enum.</para>
            /// </summary>
            Max = 12
        }

        /// <summary>
        /// <para>Particle lifetime randomness ratio.</para>
        /// </summary>
        public float LifetimeRandomness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLifetimeRandomness();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLifetimeRandomness(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Emitter will emit <c>amount</c> divided by <c>trail_divisor</c> particles. The remaining particles will be used as trail(s).</para>
        /// </summary>
        public int TrailDivisor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTrailDivisor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTrailDivisor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Trail particles' size will vary along this <see cref="Godot.CurveTexture"/>.</para>
        /// </summary>
        public CurveTexture TrailSizeModifier
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTrailSizeModifier();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTrailSizeModifier(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Trail particles' color will vary along this <see cref="Godot.GradientTexture"/>.</para>
        /// </summary>
        public GradientTexture TrailColorModifier
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTrailColorModifier();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTrailColorModifier(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Particles will be emitted inside this region. Use <see cref="Godot.ParticlesMaterial.EmissionShapeEnum"/> constants for values.</para>
        /// </summary>
        public ParticlesMaterial.EmissionShapeEnum EmissionShape
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionShape();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionShape(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The sphere's radius if <c>emission_shape</c> is set to <see cref="Godot.ParticlesMaterial.EmissionShapeEnum.Sphere"/>.</para>
        /// </summary>
        public float EmissionSphereRadius
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionSphereRadius();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionSphereRadius(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The box's extents if <c>emission_shape</c> is set to <see cref="Godot.ParticlesMaterial.EmissionShapeEnum.Box"/>.</para>
        /// </summary>
        public Vector3 EmissionBoxExtents
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionBoxExtents();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionBoxExtents(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Particles will be emitted at positions determined by sampling this texture at a random position. Used with <see cref="Godot.ParticlesMaterial.EmissionShapeEnum.Points"/> and <see cref="Godot.ParticlesMaterial.EmissionShapeEnum.DirectedPoints"/>. Can be created automatically from mesh or node by selecting "Create Emission Points from Mesh/Node" under the "Particles" tool in the toolbar.</para>
        /// </summary>
        public Texture EmissionPointTexture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionPointTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionPointTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Particle velocity and rotation will be set by sampling this texture at the same point as the <see cref="Godot.ParticlesMaterial.EmissionPointTexture"/>. Used only in <see cref="Godot.ParticlesMaterial.EmissionShapeEnum.DirectedPoints"/>. Can be created automatically from mesh or node by selecting "Create Emission Points from Mesh/Node" under the "Particles" tool in the toolbar.</para>
        /// </summary>
        public Texture EmissionNormalTexture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionNormalTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionNormalTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Particle color will be modulated by color determined by sampling this texture at the same point as the <see cref="Godot.ParticlesMaterial.EmissionPointTexture"/>.</para>
        /// </summary>
        public Texture EmissionColorTexture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionColorTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionColorTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of emission points if <c>emission_shape</c> is set to <see cref="Godot.ParticlesMaterial.EmissionShapeEnum.Points"/> or <see cref="Godot.ParticlesMaterial.EmissionShapeEnum.DirectedPoints"/>.</para>
        /// </summary>
        public int EmissionPointCount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionPointCount();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionPointCount(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The radius of the ring when using the emitter <see cref="Godot.ParticlesMaterial.EmissionShapeEnum.Ring"/>.</para>
        /// </summary>
        public float EmissionRingRadius
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionRingRadius();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionRingRadius(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The inner radius of the ring when using the emitter <see cref="Godot.ParticlesMaterial.EmissionShapeEnum.Ring"/>.</para>
        /// </summary>
        public float EmissionRingInnerRadius
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionRingInnerRadius();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionRingInnerRadius(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The height of the ring when using the emitter <see cref="Godot.ParticlesMaterial.EmissionShapeEnum.Ring"/>.</para>
        /// </summary>
        public float EmissionRingHeight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionRingHeight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionRingHeight(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The axis of the ring when using the emitter <see cref="Godot.ParticlesMaterial.EmissionShapeEnum.Ring"/>.</para>
        /// </summary>
        public Vector3 EmissionRingAxis
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionRingAxis();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionRingAxis(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Align Y axis of particle with the direction of its velocity.</para>
        /// </summary>
        public bool FlagAlignY
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((ParticlesMaterial.Flags)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((ParticlesMaterial.Flags)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, particles rotate around Y axis by <see cref="Godot.ParticlesMaterial.Angle"/>.</para>
        /// </summary>
        public bool FlagRotateY
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((ParticlesMaterial.Flags)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((ParticlesMaterial.Flags)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, particles will not move on the z axis.</para>
        /// </summary>
        public bool FlagDisableZ
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlag((ParticlesMaterial.Flags)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlag((ParticlesMaterial.Flags)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Unit vector specifying the particles' emission direction.</para>
        /// </summary>
        public Vector3 Direction
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDirection();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDirection(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's initial direction range from <c>+spread</c> to <c>-spread</c> degrees.</para>
        /// </summary>
        public float Spread
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpread();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpread(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Amount of <see cref="Godot.ParticlesMaterial.Spread"/> along the Y axis.</para>
        /// </summary>
        public float Flatness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlatness();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlatness(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Gravity applied to every particle.</para>
        /// </summary>
        public Vector3 Gravity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGravity();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGravity(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Initial velocity magnitude for each particle. Direction comes from <see cref="Godot.ParticlesMaterial.Spread"/> and the node's orientation.</para>
        /// </summary>
        public float InitialVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((ParticlesMaterial.Parameter)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((ParticlesMaterial.Parameter)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Initial velocity randomness ratio.</para>
        /// </summary>
        public float InitialVelocityRandom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamRandomness((ParticlesMaterial.Parameter)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((ParticlesMaterial.Parameter)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Initial angular velocity applied to each particle in degrees per second. Sets the speed of rotation of the particle.</para>
        /// <para>Note: Only applied when <see cref="Godot.ParticlesMaterial.FlagDisableZ"/> or <see cref="Godot.ParticlesMaterial.FlagRotateY"/> are <c>true</c> or the <see cref="Godot.SpatialMaterial"/> being used to draw the particle is using <see cref="Godot.SpatialMaterial.BillboardMode.Particles"/>.</para>
        /// </summary>
        public float AngularVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((ParticlesMaterial.Parameter)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((ParticlesMaterial.Parameter)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Angular velocity randomness ratio.</para>
        /// </summary>
        public float AngularVelocityRandom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamRandomness((ParticlesMaterial.Parameter)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((ParticlesMaterial.Parameter)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's angular velocity will vary along this <see cref="Godot.CurveTexture"/>.</para>
        /// </summary>
        public Texture AngularVelocityCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamTexture((ParticlesMaterial.Parameter)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamTexture((ParticlesMaterial.Parameter)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Orbital velocity applied to each particle. Makes the particles circle around origin. Specified in number of full rotations around origin per second.</para>
        /// <para>Note: Only available when <see cref="Godot.ParticlesMaterial.FlagDisableZ"/> is <c>true</c>.</para>
        /// </summary>
        public float OrbitVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((ParticlesMaterial.Parameter)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((ParticlesMaterial.Parameter)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Orbital velocity randomness ratio.</para>
        /// </summary>
        public float OrbitVelocityRandom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamRandomness((ParticlesMaterial.Parameter)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((ParticlesMaterial.Parameter)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's orbital velocity will vary along this <see cref="Godot.CurveTexture"/>.</para>
        /// </summary>
        public Texture OrbitVelocityCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamTexture((ParticlesMaterial.Parameter)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamTexture((ParticlesMaterial.Parameter)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Linear acceleration applied to each particle in the direction of motion.</para>
        /// </summary>
        public float LinearAccel
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((ParticlesMaterial.Parameter)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((ParticlesMaterial.Parameter)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Linear acceleration randomness ratio.</para>
        /// </summary>
        public float LinearAccelRandom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamRandomness((ParticlesMaterial.Parameter)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((ParticlesMaterial.Parameter)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's linear acceleration will vary along this <see cref="Godot.CurveTexture"/>.</para>
        /// </summary>
        public Texture LinearAccelCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamTexture((ParticlesMaterial.Parameter)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamTexture((ParticlesMaterial.Parameter)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Radial acceleration applied to each particle. Makes particle accelerate away from origin.</para>
        /// </summary>
        public float RadialAccel
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((ParticlesMaterial.Parameter)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((ParticlesMaterial.Parameter)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Radial acceleration randomness ratio.</para>
        /// </summary>
        public float RadialAccelRandom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamRandomness((ParticlesMaterial.Parameter)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((ParticlesMaterial.Parameter)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's radial acceleration will vary along this <see cref="Godot.CurveTexture"/>.</para>
        /// </summary>
        public Texture RadialAccelCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamTexture((ParticlesMaterial.Parameter)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamTexture((ParticlesMaterial.Parameter)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Tangential acceleration applied to each particle. Tangential acceleration is perpendicular to the particle's velocity giving the particles a swirling motion.</para>
        /// </summary>
        public float TangentialAccel
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((ParticlesMaterial.Parameter)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((ParticlesMaterial.Parameter)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Tangential acceleration randomness ratio.</para>
        /// </summary>
        public float TangentialAccelRandom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamRandomness((ParticlesMaterial.Parameter)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((ParticlesMaterial.Parameter)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's tangential acceleration will vary along this <see cref="Godot.CurveTexture"/>.</para>
        /// </summary>
        public Texture TangentialAccelCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamTexture((ParticlesMaterial.Parameter)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamTexture((ParticlesMaterial.Parameter)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The rate at which particles lose velocity.</para>
        /// </summary>
        public float Damping
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((ParticlesMaterial.Parameter)6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((ParticlesMaterial.Parameter)6, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Damping randomness ratio.</para>
        /// </summary>
        public float DampingRandom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamRandomness((ParticlesMaterial.Parameter)6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((ParticlesMaterial.Parameter)6, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Damping will vary along this <see cref="Godot.CurveTexture"/>.</para>
        /// </summary>
        public Texture DampingCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamTexture((ParticlesMaterial.Parameter)6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamTexture((ParticlesMaterial.Parameter)6, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Initial rotation applied to each particle, in degrees.</para>
        /// <para>Note: Only applied when <see cref="Godot.ParticlesMaterial.FlagDisableZ"/> or <see cref="Godot.ParticlesMaterial.FlagRotateY"/> are <c>true</c> or the <see cref="Godot.SpatialMaterial"/> being used to draw the particle is using <see cref="Godot.SpatialMaterial.BillboardMode.Particles"/>.</para>
        /// </summary>
        public float Angle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((ParticlesMaterial.Parameter)7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((ParticlesMaterial.Parameter)7, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Rotation randomness ratio.</para>
        /// </summary>
        public float AngleRandom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamRandomness((ParticlesMaterial.Parameter)7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((ParticlesMaterial.Parameter)7, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's rotation will be animated along this <see cref="Godot.CurveTexture"/>.</para>
        /// </summary>
        public Texture AngleCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamTexture((ParticlesMaterial.Parameter)7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamTexture((ParticlesMaterial.Parameter)7, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Initial scale applied to each particle.</para>
        /// </summary>
        public float Scale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((ParticlesMaterial.Parameter)8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((ParticlesMaterial.Parameter)8, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Scale randomness ratio.</para>
        /// </summary>
        public float ScaleRandom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamRandomness((ParticlesMaterial.Parameter)8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((ParticlesMaterial.Parameter)8, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's scale will vary along this <see cref="Godot.CurveTexture"/>.</para>
        /// </summary>
        public Texture ScaleCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamTexture((ParticlesMaterial.Parameter)8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamTexture((ParticlesMaterial.Parameter)8, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's initial color. If the <see cref="Godot.Particles2D"/>'s <c>texture</c> is defined, it will be multiplied by this color. To have particle display color in a <see cref="Godot.SpatialMaterial"/> make sure to set <see cref="Godot.SpatialMaterial.VertexColorUseAsAlbedo"/> to <c>true</c>.</para>
        /// </summary>
        public Color Color
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's color will vary along this <see cref="Godot.GradientTexture"/> over its lifetime (multiplied with <see cref="Godot.ParticlesMaterial.Color"/>).</para>
        /// </summary>
        public Texture ColorRamp
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColorRamp();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetColorRamp(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's initial color will vary along this <see cref="Godot.GradientTexture"/> (multiplied with <see cref="Godot.ParticlesMaterial.Color"/>).</para>
        /// </summary>
        public Texture ColorInitialRamp
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColorInitialRamp();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetColorInitialRamp(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Initial hue variation applied to each particle.</para>
        /// </summary>
        public float HueVariation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((ParticlesMaterial.Parameter)9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((ParticlesMaterial.Parameter)9, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Hue variation randomness ratio.</para>
        /// </summary>
        public float HueVariationRandom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamRandomness((ParticlesMaterial.Parameter)9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((ParticlesMaterial.Parameter)9, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's hue will vary along this <see cref="Godot.CurveTexture"/>.</para>
        /// </summary>
        public Texture HueVariationCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamTexture((ParticlesMaterial.Parameter)9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamTexture((ParticlesMaterial.Parameter)9, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Particle animation speed.</para>
        /// </summary>
        public float AnimSpeed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((ParticlesMaterial.Parameter)10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((ParticlesMaterial.Parameter)10, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Animation speed randomness ratio.</para>
        /// </summary>
        public float AnimSpeedRandom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamRandomness((ParticlesMaterial.Parameter)10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((ParticlesMaterial.Parameter)10, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's animation speed will vary along this <see cref="Godot.CurveTexture"/>.</para>
        /// </summary>
        public Texture AnimSpeedCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamTexture((ParticlesMaterial.Parameter)10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamTexture((ParticlesMaterial.Parameter)10, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Particle animation offset.</para>
        /// </summary>
        public float AnimOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((ParticlesMaterial.Parameter)11);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((ParticlesMaterial.Parameter)11, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Animation offset randomness ratio.</para>
        /// </summary>
        public float AnimOffsetRandom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamRandomness((ParticlesMaterial.Parameter)11);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((ParticlesMaterial.Parameter)11, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's animation offset will vary along this <see cref="Godot.CurveTexture"/>.</para>
        /// </summary>
        public Texture AnimOffsetCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamTexture((ParticlesMaterial.Parameter)11);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamTexture((ParticlesMaterial.Parameter)11, value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ParticlesMaterial";

        public ParticlesMaterial() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ParticlesMaterial_Ctor(this);
        }

        internal ParticlesMaterial(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_direction");

        [GodotMethod("set_direction")]
        [Obsolete("SetDirection is deprecated. Use the Direction property instead.")]
        public void SetDirection(Vector3 degrees)
        {
            NativeCalls.godot_icall_1_148(method_bind_0, Object.GetPtr(this), ref degrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_direction");

        [GodotMethod("get_direction")]
        [Obsolete("GetDirection is deprecated. Use the Direction property instead.")]
        public Vector3 GetDirection()
        {
            NativeCalls.godot_icall_0_8(method_bind_1, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_spread");

        [GodotMethod("set_spread")]
        [Obsolete("SetSpread is deprecated. Use the Spread property instead.")]
        public void SetSpread(float degrees)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), degrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_spread");

        [GodotMethod("get_spread")]
        [Obsolete("GetSpread is deprecated. Use the Spread property instead.")]
        public float GetSpread()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flatness");

        [GodotMethod("set_flatness")]
        [Obsolete("SetFlatness is deprecated. Use the Flatness property instead.")]
        public void SetFlatness(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_flatness");

        [GodotMethod("get_flatness")]
        [Obsolete("GetFlatness is deprecated. Use the Flatness property instead.")]
        public float GetFlatness()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_param");

        /// <summary>
        /// <para>Sets the specified <see cref="Godot.ParticlesMaterial.Parameter"/>.</para>
        /// </summary>
        [GodotMethod("set_param")]
        [Obsolete("SetParam is deprecated. Use the AnimOffset property instead.")]
        public void SetParam(ParticlesMaterial.Parameter param, float value)
        {
            NativeCalls.godot_icall_2_34(method_bind_6, Object.GetPtr(this), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_param");

        /// <summary>
        /// <para>Returns the value of the specified parameter.</para>
        /// </summary>
        [GodotMethod("get_param")]
        [Obsolete("GetParam is deprecated. Use the AnimOffset property instead.")]
        public float GetParam(ParticlesMaterial.Parameter param)
        {
            return NativeCalls.godot_icall_1_12(method_bind_7, Object.GetPtr(this), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_param_randomness");

        /// <summary>
        /// <para>Sets the randomness ratio for the specified <see cref="Godot.ParticlesMaterial.Parameter"/>.</para>
        /// </summary>
        [GodotMethod("set_param_randomness")]
        [Obsolete("SetParamRandomness is deprecated. Use the AnimOffsetRandom property instead.")]
        public void SetParamRandomness(ParticlesMaterial.Parameter param, float randomness)
        {
            NativeCalls.godot_icall_2_34(method_bind_8, Object.GetPtr(this), (int)param, randomness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_param_randomness");

        /// <summary>
        /// <para>Returns the randomness ratio associated with the specified parameter.</para>
        /// </summary>
        [GodotMethod("get_param_randomness")]
        [Obsolete("GetParamRandomness is deprecated. Use the AnimOffsetRandom property instead.")]
        public float GetParamRandomness(ParticlesMaterial.Parameter param)
        {
            return NativeCalls.godot_icall_1_12(method_bind_9, Object.GetPtr(this), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_param_texture");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Texture"/> for the specified <see cref="Godot.ParticlesMaterial.Parameter"/>.</para>
        /// </summary>
        [GodotMethod("set_param_texture")]
        [Obsolete("SetParamTexture is deprecated. Use the AnimOffsetCurve property instead.")]
        public void SetParamTexture(ParticlesMaterial.Parameter param, Texture texture)
        {
            NativeCalls.godot_icall_2_58(method_bind_10, Object.GetPtr(this), (int)param, Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_param_texture");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Texture"/> used by the specified parameter.</para>
        /// </summary>
        [GodotMethod("get_param_texture")]
        [Obsolete("GetParamTexture is deprecated. Use the AnimOffsetCurve property instead.")]
        public Texture GetParamTexture(ParticlesMaterial.Parameter param)
        {
            return NativeCalls.godot_icall_1_59(method_bind_11, Object.GetPtr(this), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color");

        [GodotMethod("set_color")]
        [Obsolete("SetColor is deprecated. Use the Color property instead.")]
        public void SetColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_12, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color");

        [GodotMethod("get_color")]
        [Obsolete("GetColor is deprecated. Use the Color property instead.")]
        public Color GetColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_13, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color_ramp");

        [GodotMethod("set_color_ramp")]
        [Obsolete("SetColorRamp is deprecated. Use the ColorRamp property instead.")]
        public void SetColorRamp(Texture ramp)
        {
            NativeCalls.godot_icall_1_24(method_bind_14, Object.GetPtr(this), Object.GetPtr(ramp));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color_ramp");

        [GodotMethod("get_color_ramp")]
        [Obsolete("GetColorRamp is deprecated. Use the ColorRamp property instead.")]
        public Texture GetColorRamp()
        {
            return NativeCalls.godot_icall_0_161(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color_initial_ramp");

        [GodotMethod("set_color_initial_ramp")]
        [Obsolete("SetColorInitialRamp is deprecated. Use the ColorInitialRamp property instead.")]
        public void SetColorInitialRamp(Texture ramp)
        {
            NativeCalls.godot_icall_1_24(method_bind_16, Object.GetPtr(this), Object.GetPtr(ramp));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color_initial_ramp");

        [GodotMethod("get_color_initial_ramp")]
        [Obsolete("GetColorInitialRamp is deprecated. Use the ColorInitialRamp property instead.")]
        public Texture GetColorInitialRamp()
        {
            return NativeCalls.godot_icall_0_161(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flag");

        /// <summary>
        /// <para>If <c>true</c>, enables the specified flag. See <see cref="Godot.ParticlesMaterial.Flags"/> for options.</para>
        /// </summary>
        [GodotMethod("set_flag")]
        [Obsolete("SetFlag is deprecated. Use the FlagDisableZ property instead.")]
        public void SetFlag(ParticlesMaterial.Flags flag, bool enable)
        {
            NativeCalls.godot_icall_2_23(method_bind_18, Object.GetPtr(this), (int)flag, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_flag");

        /// <summary>
        /// <para>Returns <c>true</c> if the specified flag is enabled.</para>
        /// </summary>
        [GodotMethod("get_flag")]
        [Obsolete("GetFlag is deprecated. Use the FlagDisableZ property instead.")]
        public bool GetFlag(ParticlesMaterial.Flags flag)
        {
            return NativeCalls.godot_icall_1_35(method_bind_19, Object.GetPtr(this), (int)flag);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_shape");

        [GodotMethod("set_emission_shape")]
        [Obsolete("SetEmissionShape is deprecated. Use the EmissionShape property instead.")]
        public void SetEmissionShape(ParticlesMaterial.EmissionShapeEnum shape)
        {
            NativeCalls.godot_icall_1_4(method_bind_20, Object.GetPtr(this), (int)shape);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_shape");

        [GodotMethod("get_emission_shape")]
        [Obsolete("GetEmissionShape is deprecated. Use the EmissionShape property instead.")]
        public ParticlesMaterial.EmissionShapeEnum GetEmissionShape()
        {
            return (ParticlesMaterial.EmissionShapeEnum)NativeCalls.godot_icall_0_723(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_sphere_radius");

        [GodotMethod("set_emission_sphere_radius")]
        [Obsolete("SetEmissionSphereRadius is deprecated. Use the EmissionSphereRadius property instead.")]
        public void SetEmissionSphereRadius(float radius)
        {
            NativeCalls.godot_icall_1_15(method_bind_22, Object.GetPtr(this), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_sphere_radius");

        [GodotMethod("get_emission_sphere_radius")]
        [Obsolete("GetEmissionSphereRadius is deprecated. Use the EmissionSphereRadius property instead.")]
        public float GetEmissionSphereRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_box_extents");

        [GodotMethod("set_emission_box_extents")]
        [Obsolete("SetEmissionBoxExtents is deprecated. Use the EmissionBoxExtents property instead.")]
        public void SetEmissionBoxExtents(Vector3 extents)
        {
            NativeCalls.godot_icall_1_148(method_bind_24, Object.GetPtr(this), ref extents);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_box_extents");

        [GodotMethod("get_emission_box_extents")]
        [Obsolete("GetEmissionBoxExtents is deprecated. Use the EmissionBoxExtents property instead.")]
        public Vector3 GetEmissionBoxExtents()
        {
            NativeCalls.godot_icall_0_8(method_bind_25, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_point_texture");

        [GodotMethod("set_emission_point_texture")]
        [Obsolete("SetEmissionPointTexture is deprecated. Use the EmissionPointTexture property instead.")]
        public void SetEmissionPointTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_26, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_point_texture");

        [GodotMethod("get_emission_point_texture")]
        [Obsolete("GetEmissionPointTexture is deprecated. Use the EmissionPointTexture property instead.")]
        public Texture GetEmissionPointTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_normal_texture");

        [GodotMethod("set_emission_normal_texture")]
        [Obsolete("SetEmissionNormalTexture is deprecated. Use the EmissionNormalTexture property instead.")]
        public void SetEmissionNormalTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_28, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_normal_texture");

        [GodotMethod("get_emission_normal_texture")]
        [Obsolete("GetEmissionNormalTexture is deprecated. Use the EmissionNormalTexture property instead.")]
        public Texture GetEmissionNormalTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_color_texture");

        [GodotMethod("set_emission_color_texture")]
        [Obsolete("SetEmissionColorTexture is deprecated. Use the EmissionColorTexture property instead.")]
        public void SetEmissionColorTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_30, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_color_texture");

        [GodotMethod("get_emission_color_texture")]
        [Obsolete("GetEmissionColorTexture is deprecated. Use the EmissionColorTexture property instead.")]
        public Texture GetEmissionColorTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_point_count");

        [GodotMethod("set_emission_point_count")]
        [Obsolete("SetEmissionPointCount is deprecated. Use the EmissionPointCount property instead.")]
        public void SetEmissionPointCount(int pointCount)
        {
            NativeCalls.godot_icall_1_4(method_bind_32, Object.GetPtr(this), pointCount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_point_count");

        [GodotMethod("get_emission_point_count")]
        [Obsolete("GetEmissionPointCount is deprecated. Use the EmissionPointCount property instead.")]
        public int GetEmissionPointCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_33, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_ring_radius");

        [GodotMethod("set_emission_ring_radius")]
        [Obsolete("SetEmissionRingRadius is deprecated. Use the EmissionRingRadius property instead.")]
        public void SetEmissionRingRadius(float radius)
        {
            NativeCalls.godot_icall_1_15(method_bind_34, Object.GetPtr(this), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_ring_radius");

        [GodotMethod("get_emission_ring_radius")]
        [Obsolete("GetEmissionRingRadius is deprecated. Use the EmissionRingRadius property instead.")]
        public float GetEmissionRingRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_35, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_ring_inner_radius");

        [GodotMethod("set_emission_ring_inner_radius")]
        [Obsolete("SetEmissionRingInnerRadius is deprecated. Use the EmissionRingInnerRadius property instead.")]
        public void SetEmissionRingInnerRadius(float offset)
        {
            NativeCalls.godot_icall_1_15(method_bind_36, Object.GetPtr(this), offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_ring_inner_radius");

        [GodotMethod("get_emission_ring_inner_radius")]
        [Obsolete("GetEmissionRingInnerRadius is deprecated. Use the EmissionRingInnerRadius property instead.")]
        public float GetEmissionRingInnerRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_ring_height");

        [GodotMethod("set_emission_ring_height")]
        [Obsolete("SetEmissionRingHeight is deprecated. Use the EmissionRingHeight property instead.")]
        public void SetEmissionRingHeight(float height)
        {
            NativeCalls.godot_icall_1_15(method_bind_38, Object.GetPtr(this), height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_ring_height");

        [GodotMethod("get_emission_ring_height")]
        [Obsolete("GetEmissionRingHeight is deprecated. Use the EmissionRingHeight property instead.")]
        public float GetEmissionRingHeight()
        {
            return NativeCalls.godot_icall_0_14(method_bind_39, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_ring_axis");

        [GodotMethod("set_emission_ring_axis")]
        [Obsolete("SetEmissionRingAxis is deprecated. Use the EmissionRingAxis property instead.")]
        public void SetEmissionRingAxis(Vector3 axis)
        {
            NativeCalls.godot_icall_1_148(method_bind_40, Object.GetPtr(this), ref axis);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_ring_axis");

        [GodotMethod("get_emission_ring_axis")]
        [Obsolete("GetEmissionRingAxis is deprecated. Use the EmissionRingAxis property instead.")]
        public Vector3 GetEmissionRingAxis()
        {
            NativeCalls.godot_icall_0_8(method_bind_41, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_trail_divisor");

        [GodotMethod("set_trail_divisor")]
        [Obsolete("SetTrailDivisor is deprecated. Use the TrailDivisor property instead.")]
        public void SetTrailDivisor(int divisor)
        {
            NativeCalls.godot_icall_1_4(method_bind_42, Object.GetPtr(this), divisor);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_trail_divisor");

        [GodotMethod("get_trail_divisor")]
        [Obsolete("GetTrailDivisor is deprecated. Use the TrailDivisor property instead.")]
        public int GetTrailDivisor()
        {
            return NativeCalls.godot_icall_0_5(method_bind_43, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_trail_size_modifier");

        [GodotMethod("set_trail_size_modifier")]
        [Obsolete("SetTrailSizeModifier is deprecated. Use the TrailSizeModifier property instead.")]
        public void SetTrailSizeModifier(CurveTexture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_44, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_trail_size_modifier");

        [GodotMethod("get_trail_size_modifier")]
        [Obsolete("GetTrailSizeModifier is deprecated. Use the TrailSizeModifier property instead.")]
        public CurveTexture GetTrailSizeModifier()
        {
            return NativeCalls.godot_icall_0_724(method_bind_45, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_trail_color_modifier");

        [GodotMethod("set_trail_color_modifier")]
        [Obsolete("SetTrailColorModifier is deprecated. Use the TrailColorModifier property instead.")]
        public void SetTrailColorModifier(GradientTexture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_46, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_trail_color_modifier");

        [GodotMethod("get_trail_color_modifier")]
        [Obsolete("GetTrailColorModifier is deprecated. Use the TrailColorModifier property instead.")]
        public GradientTexture GetTrailColorModifier()
        {
            return NativeCalls.godot_icall_0_725(method_bind_47, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gravity");

        [GodotMethod("get_gravity")]
        [Obsolete("GetGravity is deprecated. Use the Gravity property instead.")]
        public Vector3 GetGravity()
        {
            NativeCalls.godot_icall_0_8(method_bind_48, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gravity");

        [GodotMethod("set_gravity")]
        [Obsolete("SetGravity is deprecated. Use the Gravity property instead.")]
        public void SetGravity(Vector3 accelVec)
        {
            NativeCalls.godot_icall_1_148(method_bind_49, Object.GetPtr(this), ref accelVec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_lifetime_randomness");

        [GodotMethod("set_lifetime_randomness")]
        [Obsolete("SetLifetimeRandomness is deprecated. Use the LifetimeRandomness property instead.")]
        public void SetLifetimeRandomness(float randomness)
        {
            NativeCalls.godot_icall_1_15(method_bind_50, Object.GetPtr(this), randomness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_lifetime_randomness");

        [GodotMethod("get_lifetime_randomness")]
        [Obsolete("GetLifetimeRandomness is deprecated. Use the LifetimeRandomness property instead.")]
        public float GetLifetimeRandomness()
        {
            return NativeCalls.godot_icall_0_14(method_bind_51, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
