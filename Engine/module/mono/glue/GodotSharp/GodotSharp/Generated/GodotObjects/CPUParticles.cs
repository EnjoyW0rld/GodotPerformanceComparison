using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>CPU-based 3D particle node used to create a variety of particle systems and effects.</para>
    /// <para>See also <see cref="Godot.Particles"/>, which provides the same functionality with hardware acceleration, but may not run on older devices.</para>
    /// <para>Note: Unlike <see cref="Godot.Particles"/>, the visibility rect is generated on-the-fly and doesn't need to be configured by the user.</para>
    /// </summary>
    public partial class CPUParticles : GeometryInstance
    {
        public enum Flags
        {
            /// <summary>
            /// <para>Use with <see cref="Godot.CPUParticles.SetParticleFlag"/> to set <see cref="Godot.CPUParticles.FlagAlignY"/>.</para>
            /// </summary>
            AlignYToVelocity = 0,
            /// <summary>
            /// <para>Use with <see cref="Godot.CPUParticles.SetParticleFlag"/> to set <see cref="Godot.CPUParticles.FlagRotateY"/>.</para>
            /// </summary>
            RotateY = 1,
            /// <summary>
            /// <para>Use with <see cref="Godot.CPUParticles.SetParticleFlag"/> to set <see cref="Godot.CPUParticles.FlagDisableZ"/>.</para>
            /// </summary>
            DisableZ = 2,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.CPUParticles.Flags"/> enum.</para>
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
            /// <para>Particles will be emitted at a position chosen randomly among <see cref="Godot.CPUParticles.EmissionPoints"/>. Particle color will be modulated by <see cref="Godot.CPUParticles.EmissionColors"/>.</para>
            /// </summary>
            Points = 3,
            /// <summary>
            /// <para>Particles will be emitted at a position chosen randomly among <see cref="Godot.CPUParticles.EmissionPoints"/>. Particle velocity and rotation will be set based on <see cref="Godot.CPUParticles.EmissionNormals"/>. Particle color will be modulated by <see cref="Godot.CPUParticles.EmissionColors"/>.</para>
            /// </summary>
            DirectedPoints = 4,
            /// <summary>
            /// <para>Particles will be emitted in a ring or cylinder.</para>
            /// </summary>
            Ring = 5,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.CPUParticles.EmissionShapeEnum"/> enum.</para>
            /// </summary>
            Max = 6
        }

        public enum Parameter
        {
            /// <summary>
            /// <para>Use with <see cref="Godot.CPUParticles.SetParam"/>, <see cref="Godot.CPUParticles.SetParamRandomness"/>, and <see cref="Godot.CPUParticles.SetParamCurve"/> to set initial velocity properties.</para>
            /// </summary>
            InitialLinearVelocity = 0,
            /// <summary>
            /// <para>Use with <see cref="Godot.CPUParticles.SetParam"/>, <see cref="Godot.CPUParticles.SetParamRandomness"/>, and <see cref="Godot.CPUParticles.SetParamCurve"/> to set angular velocity properties.</para>
            /// </summary>
            AngularVelocity = 1,
            /// <summary>
            /// <para>Use with <see cref="Godot.CPUParticles.SetParam"/>, <see cref="Godot.CPUParticles.SetParamRandomness"/>, and <see cref="Godot.CPUParticles.SetParamCurve"/> to set orbital velocity properties.</para>
            /// </summary>
            OrbitVelocity = 2,
            /// <summary>
            /// <para>Use with <see cref="Godot.CPUParticles.SetParam"/>, <see cref="Godot.CPUParticles.SetParamRandomness"/>, and <see cref="Godot.CPUParticles.SetParamCurve"/> to set linear acceleration properties.</para>
            /// </summary>
            LinearAccel = 3,
            /// <summary>
            /// <para>Use with <see cref="Godot.CPUParticles.SetParam"/>, <see cref="Godot.CPUParticles.SetParamRandomness"/>, and <see cref="Godot.CPUParticles.SetParamCurve"/> to set radial acceleration properties.</para>
            /// </summary>
            RadialAccel = 4,
            /// <summary>
            /// <para>Use with <see cref="Godot.CPUParticles.SetParam"/>, <see cref="Godot.CPUParticles.SetParamRandomness"/>, and <see cref="Godot.CPUParticles.SetParamCurve"/> to set tangential acceleration properties.</para>
            /// </summary>
            TangentialAccel = 5,
            /// <summary>
            /// <para>Use with <see cref="Godot.CPUParticles.SetParam"/>, <see cref="Godot.CPUParticles.SetParamRandomness"/>, and <see cref="Godot.CPUParticles.SetParamCurve"/> to set damping properties.</para>
            /// </summary>
            Damping = 6,
            /// <summary>
            /// <para>Use with <see cref="Godot.CPUParticles.SetParam"/>, <see cref="Godot.CPUParticles.SetParamRandomness"/>, and <see cref="Godot.CPUParticles.SetParamCurve"/> to set angle properties.</para>
            /// </summary>
            Angle = 7,
            /// <summary>
            /// <para>Use with <see cref="Godot.CPUParticles.SetParam"/>, <see cref="Godot.CPUParticles.SetParamRandomness"/>, and <see cref="Godot.CPUParticles.SetParamCurve"/> to set scale properties.</para>
            /// </summary>
            Scale = 8,
            /// <summary>
            /// <para>Use with <see cref="Godot.CPUParticles.SetParam"/>, <see cref="Godot.CPUParticles.SetParamRandomness"/>, and <see cref="Godot.CPUParticles.SetParamCurve"/> to set hue variation properties.</para>
            /// </summary>
            HueVariation = 9,
            /// <summary>
            /// <para>Use with <see cref="Godot.CPUParticles.SetParam"/>, <see cref="Godot.CPUParticles.SetParamRandomness"/>, and <see cref="Godot.CPUParticles.SetParamCurve"/> to set animation speed properties.</para>
            /// </summary>
            AnimSpeed = 10,
            /// <summary>
            /// <para>Use with <see cref="Godot.CPUParticles.SetParam"/>, <see cref="Godot.CPUParticles.SetParamRandomness"/>, and <see cref="Godot.CPUParticles.SetParamCurve"/> to set animation offset properties.</para>
            /// </summary>
            AnimOffset = 11,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.CPUParticles.Parameter"/> enum.</para>
            /// </summary>
            Max = 12
        }

        public enum DrawOrderEnum
        {
            /// <summary>
            /// <para>Particles are drawn in the order emitted.</para>
            /// </summary>
            Index = 0,
            /// <summary>
            /// <para>Particles are drawn in order of remaining lifetime.</para>
            /// </summary>
            Lifetime = 1,
            /// <summary>
            /// <para>Particles are drawn in order of depth.</para>
            /// </summary>
            ViewDepth = 2
        }

        /// <summary>
        /// <para>If <c>true</c>, particles are being emitted.</para>
        /// </summary>
        public bool Emitting
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEmitting();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmitting(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of particles emitted in one emission cycle (corresponding to the <see cref="Godot.CPUParticles.Lifetime"/>).</para>
        /// <para>Note: Changing <see cref="Godot.CPUParticles.Amount"/> will reset the particle emission, therefore removing all particles that were already emitted before changing <see cref="Godot.CPUParticles.Amount"/>.</para>
        /// </summary>
        public int Amount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAmount();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAmount(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of time each particle will exist (in seconds).</para>
        /// </summary>
        public float Lifetime
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLifetime();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLifetime(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, only one emission cycle occurs. If set <c>true</c> during a cycle, emission will stop at the cycle's end.</para>
        /// </summary>
        public bool OneShot
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOneShot();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOneShot(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Particle system starts as if it had already run for this many seconds.</para>
        /// </summary>
        public float Preprocess
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPreProcessTime();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPreProcessTime(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Particle system's running speed scaling ratio. A value of <c>0</c> can be used to pause the particles.</para>
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
        /// <para>How rapidly particles in an emission cycle are emitted. If greater than <c>0</c>, there will be a gap in emissions before the next cycle begins.</para>
        /// </summary>
        public float Explosiveness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExplosivenessRatio();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExplosivenessRatio(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Emission lifetime randomness ratio.</para>
        /// </summary>
        public float Randomness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRandomnessRatio();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRandomnessRatio(value);
            }
#pragma warning restore CS0618
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
        /// <para>The particle system's frame rate is fixed to a value. For instance, changing the value to 2 will make the particles render at 2 frames per second. Note this does not slow down the particle system itself.</para>
        /// </summary>
        public int FixedFps
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFixedFps();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFixedFps(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, results in fractional delta calculation which has a smoother particles display effect.</para>
        /// </summary>
        public bool FractDelta
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFractionalDelta();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFractionalDelta(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, particles use the parent node's coordinate space. If <c>false</c>, they use global coordinates.</para>
        /// </summary>
        public bool LocalCoords
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUseLocalCoordinates();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseLocalCoordinates(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Particle draw order. Uses <see cref="Godot.CPUParticles.DrawOrderEnum"/> values.</para>
        /// </summary>
        public CPUParticles.DrawOrderEnum DrawOrder
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDrawOrder();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawOrder(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.Mesh"/> used for each particle. If <c>null</c>, particles will be spheres.</para>
        /// </summary>
        public Mesh Mesh
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMesh();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMesh(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Particles will be emitted inside this region. See <see cref="Godot.CPUParticles.EmissionShapeEnum"/> for possible values.</para>
        /// </summary>
        public CPUParticles.EmissionShapeEnum EmissionShape
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
        /// <para>The sphere's radius if <see cref="Godot.CPUParticles.EmissionShapeEnum"/> is set to <see cref="Godot.CPUParticles.EmissionShapeEnum.Sphere"/>.</para>
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
        /// <para>The rectangle's extents if <see cref="Godot.CPUParticles.EmissionShape"/> is set to <see cref="Godot.CPUParticles.EmissionShapeEnum.Box"/>.</para>
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
        /// <para>Sets the initial positions to spawn particles when using <see cref="Godot.CPUParticles.EmissionShapeEnum.Points"/> or <see cref="Godot.CPUParticles.EmissionShapeEnum.DirectedPoints"/>.</para>
        /// </summary>
        public Vector3[] EmissionPoints
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionPoints();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionPoints(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the direction the particles will be emitted in when using <see cref="Godot.CPUParticles.EmissionShapeEnum.DirectedPoints"/>.</para>
        /// </summary>
        public Vector3[] EmissionNormals
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionNormals();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionNormals(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the <see cref="Godot.Color"/>s to modulate particles by when using <see cref="Godot.CPUParticles.EmissionShapeEnum.Points"/> or <see cref="Godot.CPUParticles.EmissionShapeEnum.DirectedPoints"/>.</para>
        /// </summary>
        public Color[] EmissionColors
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEmissionColors();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmissionColors(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The radius for the ring shaped emitter when using <see cref="Godot.CPUParticles.EmissionShapeEnum.Ring"/>.</para>
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
        /// <para>The inner radius for the ring shaped emitter when using <see cref="Godot.CPUParticles.EmissionShapeEnum.Ring"/>.</para>
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
        /// <para>The height for the ring shaped emitter when using <see cref="Godot.CPUParticles.EmissionShapeEnum.Ring"/>.</para>
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
        /// <para>The axis for the ring shaped emitter when using <see cref="Godot.CPUParticles.EmissionShapeEnum.Ring"/>.</para>
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
                return GetParticleFlag((CPUParticles.Flags)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParticleFlag((CPUParticles.Flags)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, particles rotate around Y axis by <see cref="Godot.CPUParticles.Angle"/>.</para>
        /// </summary>
        public bool FlagRotateY
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParticleFlag((CPUParticles.Flags)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParticleFlag((CPUParticles.Flags)1, value);
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
                return GetParticleFlag((CPUParticles.Flags)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParticleFlag((CPUParticles.Flags)2, value);
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
        /// <para>Each particle's initial direction range from <c>+spread</c> to <c>-spread</c> degrees. Applied to X/Z plane and Y/Z planes.</para>
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
        /// <para>Amount of <see cref="Godot.CPUParticles.Spread"/> in Y/Z plane. A value of <c>1</c> restricts particles to X/Z plane.</para>
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
        /// <para>Initial velocity magnitude for each particle. Direction comes from <see cref="Godot.CPUParticles.Spread"/> and the node's orientation.</para>
        /// </summary>
        public float InitialVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((CPUParticles.Parameter)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((CPUParticles.Parameter)0, value);
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
                return GetParamRandomness((CPUParticles.Parameter)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((CPUParticles.Parameter)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Initial angular velocity applied to each particle in degrees per second. Sets the speed of rotation of the particle.</para>
        /// </summary>
        public float AngularVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((CPUParticles.Parameter)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((CPUParticles.Parameter)1, value);
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
                return GetParamRandomness((CPUParticles.Parameter)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((CPUParticles.Parameter)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's angular velocity will vary along this <see cref="Godot.Curve"/>.</para>
        /// </summary>
        public Curve AngularVelocityCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamCurve((CPUParticles.Parameter)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamCurve((CPUParticles.Parameter)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Orbital velocity applied to each particle. Makes the particles circle around origin in the local XY plane. Specified in number of full rotations around origin per second.</para>
        /// <para>This property is only available when <see cref="Godot.CPUParticles.FlagDisableZ"/> is <c>true</c>.</para>
        /// </summary>
        public float OrbitVelocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((CPUParticles.Parameter)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((CPUParticles.Parameter)2, value);
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
                return GetParamRandomness((CPUParticles.Parameter)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((CPUParticles.Parameter)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's orbital velocity will vary along this <see cref="Godot.Curve"/>.</para>
        /// </summary>
        public Curve OrbitVelocityCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamCurve((CPUParticles.Parameter)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamCurve((CPUParticles.Parameter)2, value);
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
                return GetParam((CPUParticles.Parameter)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((CPUParticles.Parameter)3, value);
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
                return GetParamRandomness((CPUParticles.Parameter)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((CPUParticles.Parameter)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's linear acceleration will vary along this <see cref="Godot.Curve"/>.</para>
        /// </summary>
        public Curve LinearAccelCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamCurve((CPUParticles.Parameter)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamCurve((CPUParticles.Parameter)3, value);
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
                return GetParam((CPUParticles.Parameter)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((CPUParticles.Parameter)4, value);
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
                return GetParamRandomness((CPUParticles.Parameter)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((CPUParticles.Parameter)4, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's radial acceleration will vary along this <see cref="Godot.Curve"/>.</para>
        /// </summary>
        public Curve RadialAccelCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamCurve((CPUParticles.Parameter)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamCurve((CPUParticles.Parameter)4, value);
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
                return GetParam((CPUParticles.Parameter)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((CPUParticles.Parameter)5, value);
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
                return GetParamRandomness((CPUParticles.Parameter)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((CPUParticles.Parameter)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's tangential acceleration will vary along this <see cref="Godot.Curve"/>.</para>
        /// </summary>
        public Curve TangentialAccelCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamCurve((CPUParticles.Parameter)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamCurve((CPUParticles.Parameter)5, value);
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
                return GetParam((CPUParticles.Parameter)6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((CPUParticles.Parameter)6, value);
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
                return GetParamRandomness((CPUParticles.Parameter)6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((CPUParticles.Parameter)6, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Damping will vary along this <see cref="Godot.Curve"/>.</para>
        /// </summary>
        public Curve DampingCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamCurve((CPUParticles.Parameter)6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamCurve((CPUParticles.Parameter)6, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Initial rotation applied to each particle, in degrees.</para>
        /// </summary>
        public float Angle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((CPUParticles.Parameter)7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((CPUParticles.Parameter)7, value);
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
                return GetParamRandomness((CPUParticles.Parameter)7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((CPUParticles.Parameter)7, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's rotation will be animated along this <see cref="Godot.Curve"/>.</para>
        /// </summary>
        public Curve AngleCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamCurve((CPUParticles.Parameter)7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamCurve((CPUParticles.Parameter)7, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Initial scale applied to each particle.</para>
        /// </summary>
        public float ScaleAmount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParam((CPUParticles.Parameter)8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((CPUParticles.Parameter)8, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Scale randomness ratio.</para>
        /// </summary>
        public float ScaleAmountRandom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamRandomness((CPUParticles.Parameter)8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((CPUParticles.Parameter)8, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's scale will vary along this <see cref="Godot.Curve"/>.</para>
        /// </summary>
        public Curve ScaleAmountCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamCurve((CPUParticles.Parameter)8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamCurve((CPUParticles.Parameter)8, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's initial color. To have particle display color in a <see cref="Godot.SpatialMaterial"/> make sure to set <see cref="Godot.SpatialMaterial.VertexColorUseAsAlbedo"/> to <c>true</c>.</para>
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
        /// <para>Each particle's color will vary along this <see cref="Godot.GradientTexture"/> over its lifetime (multiplied with <see cref="Godot.CPUParticles.Color"/>).</para>
        /// </summary>
        public Gradient ColorRamp
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
        /// <para>Each particle's initial color will vary along this <see cref="Godot.GradientTexture"/> (multiplied with <see cref="Godot.CPUParticles.Color"/>).</para>
        /// </summary>
        public Gradient ColorInitialRamp
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
                return GetParam((CPUParticles.Parameter)9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((CPUParticles.Parameter)9, value);
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
                return GetParamRandomness((CPUParticles.Parameter)9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((CPUParticles.Parameter)9, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's hue will vary along this <see cref="Godot.Curve"/>.</para>
        /// </summary>
        public Curve HueVariationCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamCurve((CPUParticles.Parameter)9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamCurve((CPUParticles.Parameter)9, value);
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
                return GetParam((CPUParticles.Parameter)10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((CPUParticles.Parameter)10, value);
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
                return GetParamRandomness((CPUParticles.Parameter)10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((CPUParticles.Parameter)10, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's animation speed will vary along this <see cref="Godot.Curve"/>.</para>
        /// </summary>
        public Curve AnimSpeedCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamCurve((CPUParticles.Parameter)10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamCurve((CPUParticles.Parameter)10, value);
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
                return GetParam((CPUParticles.Parameter)11);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParam((CPUParticles.Parameter)11, value);
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
                return GetParamRandomness((CPUParticles.Parameter)11);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamRandomness((CPUParticles.Parameter)11, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Each particle's animation offset will vary along this <see cref="Godot.Curve"/>.</para>
        /// </summary>
        public Curve AnimOffsetCurve
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParamCurve((CPUParticles.Parameter)11);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParamCurve((CPUParticles.Parameter)11, value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CPUParticles";

        public CPUParticles() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CPUParticles_Ctor(this);
        }

        internal CPUParticles(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emitting");

        [GodotMethod("set_emitting")]
        [Obsolete("SetEmitting is deprecated. Use the Emitting property instead.")]
        public void SetEmitting(bool emitting)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), emitting);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_amount");

        [GodotMethod("set_amount")]
        [Obsolete("SetAmount is deprecated. Use the Amount property instead.")]
        public void SetAmount(int amount)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_lifetime");

        [GodotMethod("set_lifetime")]
        [Obsolete("SetLifetime is deprecated. Use the Lifetime property instead.")]
        public void SetLifetime(float secs)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), secs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_one_shot");

        [GodotMethod("set_one_shot")]
        [Obsolete("SetOneShot is deprecated. Use the OneShot property instead.")]
        public void SetOneShot(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_3, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pre_process_time");

        [GodotMethod("set_pre_process_time")]
        [Obsolete("SetPreProcessTime is deprecated. Use the Preprocess property instead.")]
        public void SetPreProcessTime(float secs)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), secs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_explosiveness_ratio");

        [GodotMethod("set_explosiveness_ratio")]
        [Obsolete("SetExplosivenessRatio is deprecated. Use the Explosiveness property instead.")]
        public void SetExplosivenessRatio(float ratio)
        {
            NativeCalls.godot_icall_1_15(method_bind_5, Object.GetPtr(this), ratio);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_randomness_ratio");

        [GodotMethod("set_randomness_ratio")]
        [Obsolete("SetRandomnessRatio is deprecated. Use the Randomness property instead.")]
        public void SetRandomnessRatio(float ratio)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), ratio);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_lifetime_randomness");

        [GodotMethod("set_lifetime_randomness")]
        [Obsolete("SetLifetimeRandomness is deprecated. Use the LifetimeRandomness property instead.")]
        public void SetLifetimeRandomness(float random)
        {
            NativeCalls.godot_icall_1_15(method_bind_7, Object.GetPtr(this), random);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_local_coordinates");

        [GodotMethod("set_use_local_coordinates")]
        [Obsolete("SetUseLocalCoordinates is deprecated. Use the LocalCoords property instead.")]
        public void SetUseLocalCoordinates(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fixed_fps");

        [GodotMethod("set_fixed_fps")]
        [Obsolete("SetFixedFps is deprecated. Use the FixedFps property instead.")]
        public void SetFixedFps(int fps)
        {
            NativeCalls.godot_icall_1_4(method_bind_9, Object.GetPtr(this), fps);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fractional_delta");

        [GodotMethod("set_fractional_delta")]
        [Obsolete("SetFractionalDelta is deprecated. Use the FractDelta property instead.")]
        public void SetFractionalDelta(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_speed_scale");

        [GodotMethod("set_speed_scale")]
        [Obsolete("SetSpeedScale is deprecated. Use the SpeedScale property instead.")]
        public void SetSpeedScale(float scale)
        {
            NativeCalls.godot_icall_1_15(method_bind_11, Object.GetPtr(this), scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_emitting");

        [GodotMethod("is_emitting")]
        [Obsolete("IsEmitting is deprecated. Use the Emitting property instead.")]
        public bool IsEmitting()
        {
            return NativeCalls.godot_icall_0_7(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_amount");

        [GodotMethod("get_amount")]
        [Obsolete("GetAmount is deprecated. Use the Amount property instead.")]
        public int GetAmount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_lifetime");

        [GodotMethod("get_lifetime")]
        [Obsolete("GetLifetime is deprecated. Use the Lifetime property instead.")]
        public float GetLifetime()
        {
            return NativeCalls.godot_icall_0_14(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_one_shot");

        [GodotMethod("get_one_shot")]
        [Obsolete("GetOneShot is deprecated. Use the OneShot property instead.")]
        public bool GetOneShot()
        {
            return NativeCalls.godot_icall_0_7(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pre_process_time");

        [GodotMethod("get_pre_process_time")]
        [Obsolete("GetPreProcessTime is deprecated. Use the Preprocess property instead.")]
        public float GetPreProcessTime()
        {
            return NativeCalls.godot_icall_0_14(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_explosiveness_ratio");

        [GodotMethod("get_explosiveness_ratio")]
        [Obsolete("GetExplosivenessRatio is deprecated. Use the Explosiveness property instead.")]
        public float GetExplosivenessRatio()
        {
            return NativeCalls.godot_icall_0_14(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_randomness_ratio");

        [GodotMethod("get_randomness_ratio")]
        [Obsolete("GetRandomnessRatio is deprecated. Use the Randomness property instead.")]
        public float GetRandomnessRatio()
        {
            return NativeCalls.godot_icall_0_14(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_lifetime_randomness");

        [GodotMethod("get_lifetime_randomness")]
        [Obsolete("GetLifetimeRandomness is deprecated. Use the LifetimeRandomness property instead.")]
        public float GetLifetimeRandomness()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_use_local_coordinates");

        [GodotMethod("get_use_local_coordinates")]
        [Obsolete("GetUseLocalCoordinates is deprecated. Use the LocalCoords property instead.")]
        public bool GetUseLocalCoordinates()
        {
            return NativeCalls.godot_icall_0_7(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fixed_fps");

        [GodotMethod("get_fixed_fps")]
        [Obsolete("GetFixedFps is deprecated. Use the FixedFps property instead.")]
        public int GetFixedFps()
        {
            return NativeCalls.godot_icall_0_5(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fractional_delta");

        [GodotMethod("get_fractional_delta")]
        [Obsolete("GetFractionalDelta is deprecated. Use the FractDelta property instead.")]
        public bool GetFractionalDelta()
        {
            return NativeCalls.godot_icall_0_7(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_speed_scale");

        [GodotMethod("get_speed_scale")]
        [Obsolete("GetSpeedScale is deprecated. Use the SpeedScale property instead.")]
        public float GetSpeedScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_draw_order");

        [GodotMethod("set_draw_order")]
        [Obsolete("SetDrawOrder is deprecated. Use the DrawOrder property instead.")]
        public void SetDrawOrder(CPUParticles.DrawOrderEnum order)
        {
            NativeCalls.godot_icall_1_4(method_bind_24, Object.GetPtr(this), (int)order);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_draw_order");

        [GodotMethod("get_draw_order")]
        [Obsolete("GetDrawOrder is deprecated. Use the DrawOrder property instead.")]
        public CPUParticles.DrawOrderEnum GetDrawOrder()
        {
            return (CPUParticles.DrawOrderEnum)NativeCalls.godot_icall_0_225(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mesh");

        [GodotMethod("set_mesh")]
        [Obsolete("SetMesh is deprecated. Use the Mesh property instead.")]
        public void SetMesh(Mesh mesh)
        {
            NativeCalls.godot_icall_1_24(method_bind_26, Object.GetPtr(this), Object.GetPtr(mesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mesh");

        [GodotMethod("get_mesh")]
        [Obsolete("GetMesh is deprecated. Use the Mesh property instead.")]
        public Mesh GetMesh()
        {
            return NativeCalls.godot_icall_0_10(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "restart");

        /// <summary>
        /// <para>Restarts the particle emitter.</para>
        /// </summary>
        [GodotMethod("restart")]
        public void Restart()
        {
            NativeCalls.godot_icall_0_3(method_bind_28, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_direction");

        [GodotMethod("set_direction")]
        [Obsolete("SetDirection is deprecated. Use the Direction property instead.")]
        public void SetDirection(Vector3 direction)
        {
            NativeCalls.godot_icall_1_148(method_bind_29, Object.GetPtr(this), ref direction);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_direction");

        [GodotMethod("get_direction")]
        [Obsolete("GetDirection is deprecated. Use the Direction property instead.")]
        public Vector3 GetDirection()
        {
            NativeCalls.godot_icall_0_8(method_bind_30, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_spread");

        [GodotMethod("set_spread")]
        [Obsolete("SetSpread is deprecated. Use the Spread property instead.")]
        public void SetSpread(float degrees)
        {
            NativeCalls.godot_icall_1_15(method_bind_31, Object.GetPtr(this), degrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_spread");

        [GodotMethod("get_spread")]
        [Obsolete("GetSpread is deprecated. Use the Spread property instead.")]
        public float GetSpread()
        {
            return NativeCalls.godot_icall_0_14(method_bind_32, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flatness");

        [GodotMethod("set_flatness")]
        [Obsolete("SetFlatness is deprecated. Use the Flatness property instead.")]
        public void SetFlatness(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_33, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_flatness");

        [GodotMethod("get_flatness")]
        [Obsolete("GetFlatness is deprecated. Use the Flatness property instead.")]
        public float GetFlatness()
        {
            return NativeCalls.godot_icall_0_14(method_bind_34, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_param");

        /// <summary>
        /// <para>Sets the base value of the parameter specified by <see cref="Godot.CPUParticles.Parameter"/>.</para>
        /// </summary>
        [GodotMethod("set_param")]
        [Obsolete("SetParam is deprecated. Use the AnimOffset property instead.")]
        public void SetParam(CPUParticles.Parameter param, float value)
        {
            NativeCalls.godot_icall_2_34(method_bind_35, Object.GetPtr(this), (int)param, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_param");

        /// <summary>
        /// <para>Returns the base value of the parameter specified by <see cref="Godot.CPUParticles.Parameter"/>.</para>
        /// </summary>
        [GodotMethod("get_param")]
        [Obsolete("GetParam is deprecated. Use the AnimOffset property instead.")]
        public float GetParam(CPUParticles.Parameter param)
        {
            return NativeCalls.godot_icall_1_12(method_bind_36, Object.GetPtr(this), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_param_randomness");

        /// <summary>
        /// <para>Sets the randomness factor of the parameter specified by <see cref="Godot.CPUParticles.Parameter"/>.</para>
        /// </summary>
        [GodotMethod("set_param_randomness")]
        [Obsolete("SetParamRandomness is deprecated. Use the AnimOffsetRandom property instead.")]
        public void SetParamRandomness(CPUParticles.Parameter param, float randomness)
        {
            NativeCalls.godot_icall_2_34(method_bind_37, Object.GetPtr(this), (int)param, randomness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_param_randomness");

        /// <summary>
        /// <para>Returns the randomness factor of the parameter specified by <see cref="Godot.CPUParticles.Parameter"/>.</para>
        /// </summary>
        [GodotMethod("get_param_randomness")]
        [Obsolete("GetParamRandomness is deprecated. Use the AnimOffsetRandom property instead.")]
        public float GetParamRandomness(CPUParticles.Parameter param)
        {
            return NativeCalls.godot_icall_1_12(method_bind_38, Object.GetPtr(this), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_param_curve");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Curve"/> of the parameter specified by <see cref="Godot.CPUParticles.Parameter"/>.</para>
        /// </summary>
        [GodotMethod("set_param_curve")]
        [Obsolete("SetParamCurve is deprecated. Use the AnimOffsetCurve property instead.")]
        public void SetParamCurve(CPUParticles.Parameter param, Curve curve)
        {
            NativeCalls.godot_icall_2_58(method_bind_39, Object.GetPtr(this), (int)param, Object.GetPtr(curve));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_param_curve");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Curve"/> of the parameter specified by <see cref="Godot.CPUParticles.Parameter"/>.</para>
        /// </summary>
        [GodotMethod("get_param_curve")]
        [Obsolete("GetParamCurve is deprecated. Use the AnimOffsetCurve property instead.")]
        public Curve GetParamCurve(CPUParticles.Parameter param)
        {
            return NativeCalls.godot_icall_1_226(method_bind_40, Object.GetPtr(this), (int)param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color");

        [GodotMethod("set_color")]
        [Obsolete("SetColor is deprecated. Use the Color property instead.")]
        public void SetColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_41, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color");

        [GodotMethod("get_color")]
        [Obsolete("GetColor is deprecated. Use the Color property instead.")]
        public Color GetColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_42, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color_ramp");

        [GodotMethod("set_color_ramp")]
        [Obsolete("SetColorRamp is deprecated. Use the ColorRamp property instead.")]
        public void SetColorRamp(Gradient ramp)
        {
            NativeCalls.godot_icall_1_24(method_bind_43, Object.GetPtr(this), Object.GetPtr(ramp));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color_ramp");

        [GodotMethod("get_color_ramp")]
        [Obsolete("GetColorRamp is deprecated. Use the ColorRamp property instead.")]
        public Gradient GetColorRamp()
        {
            return NativeCalls.godot_icall_0_227(method_bind_44, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color_initial_ramp");

        [GodotMethod("set_color_initial_ramp")]
        [Obsolete("SetColorInitialRamp is deprecated. Use the ColorInitialRamp property instead.")]
        public void SetColorInitialRamp(Gradient ramp)
        {
            NativeCalls.godot_icall_1_24(method_bind_45, Object.GetPtr(this), Object.GetPtr(ramp));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color_initial_ramp");

        [GodotMethod("get_color_initial_ramp")]
        [Obsolete("GetColorInitialRamp is deprecated. Use the ColorInitialRamp property instead.")]
        public Gradient GetColorInitialRamp()
        {
            return NativeCalls.godot_icall_0_227(method_bind_46, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_particle_flag");

        /// <summary>
        /// <para>Enables or disables the given flag (see <see cref="Godot.CPUParticles.Flags"/> for options).</para>
        /// </summary>
        [GodotMethod("set_particle_flag")]
        [Obsolete("SetParticleFlag is deprecated. Use the FlagDisableZ property instead.")]
        public void SetParticleFlag(CPUParticles.Flags flag, bool enable)
        {
            NativeCalls.godot_icall_2_23(method_bind_47, Object.GetPtr(this), (int)flag, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_particle_flag");

        /// <summary>
        /// <para>Returns the enabled state of the given flag (see <see cref="Godot.CPUParticles.Flags"/> for options).</para>
        /// </summary>
        [GodotMethod("get_particle_flag")]
        [Obsolete("GetParticleFlag is deprecated. Use the FlagDisableZ property instead.")]
        public bool GetParticleFlag(CPUParticles.Flags flag)
        {
            return NativeCalls.godot_icall_1_35(method_bind_48, Object.GetPtr(this), (int)flag);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_shape");

        [GodotMethod("set_emission_shape")]
        [Obsolete("SetEmissionShape is deprecated. Use the EmissionShape property instead.")]
        public void SetEmissionShape(CPUParticles.EmissionShapeEnum shape)
        {
            NativeCalls.godot_icall_1_4(method_bind_49, Object.GetPtr(this), (int)shape);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_shape");

        [GodotMethod("get_emission_shape")]
        [Obsolete("GetEmissionShape is deprecated. Use the EmissionShape property instead.")]
        public CPUParticles.EmissionShapeEnum GetEmissionShape()
        {
            return (CPUParticles.EmissionShapeEnum)NativeCalls.godot_icall_0_228(method_bind_50, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_sphere_radius");

        [GodotMethod("set_emission_sphere_radius")]
        [Obsolete("SetEmissionSphereRadius is deprecated. Use the EmissionSphereRadius property instead.")]
        public void SetEmissionSphereRadius(float radius)
        {
            NativeCalls.godot_icall_1_15(method_bind_51, Object.GetPtr(this), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_sphere_radius");

        [GodotMethod("get_emission_sphere_radius")]
        [Obsolete("GetEmissionSphereRadius is deprecated. Use the EmissionSphereRadius property instead.")]
        public float GetEmissionSphereRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_52, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_box_extents");

        [GodotMethod("set_emission_box_extents")]
        [Obsolete("SetEmissionBoxExtents is deprecated. Use the EmissionBoxExtents property instead.")]
        public void SetEmissionBoxExtents(Vector3 extents)
        {
            NativeCalls.godot_icall_1_148(method_bind_53, Object.GetPtr(this), ref extents);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_box_extents");

        [GodotMethod("get_emission_box_extents")]
        [Obsolete("GetEmissionBoxExtents is deprecated. Use the EmissionBoxExtents property instead.")]
        public Vector3 GetEmissionBoxExtents()
        {
            NativeCalls.godot_icall_0_8(method_bind_54, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_points");

        [GodotMethod("set_emission_points")]
        [Obsolete("SetEmissionPoints is deprecated. Use the EmissionPoints property instead.")]
        public void SetEmissionPoints(Vector3[] array)
        {
            NativeCalls.godot_icall_1_229(method_bind_55, Object.GetPtr(this), array);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_points");

        [GodotMethod("get_emission_points")]
        [Obsolete("GetEmissionPoints is deprecated. Use the EmissionPoints property instead.")]
        public Vector3[] GetEmissionPoints()
        {
            return NativeCalls.godot_icall_0_230(method_bind_56, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_normals");

        [GodotMethod("set_emission_normals")]
        [Obsolete("SetEmissionNormals is deprecated. Use the EmissionNormals property instead.")]
        public void SetEmissionNormals(Vector3[] array)
        {
            NativeCalls.godot_icall_1_229(method_bind_57, Object.GetPtr(this), array);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_normals");

        [GodotMethod("get_emission_normals")]
        [Obsolete("GetEmissionNormals is deprecated. Use the EmissionNormals property instead.")]
        public Vector3[] GetEmissionNormals()
        {
            return NativeCalls.godot_icall_0_230(method_bind_58, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_colors");

        [GodotMethod("set_emission_colors")]
        [Obsolete("SetEmissionColors is deprecated. Use the EmissionColors property instead.")]
        public void SetEmissionColors(Color[] array)
        {
            NativeCalls.godot_icall_1_231(method_bind_59, Object.GetPtr(this), array);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_colors");

        [GodotMethod("get_emission_colors")]
        [Obsolete("GetEmissionColors is deprecated. Use the EmissionColors property instead.")]
        public Color[] GetEmissionColors()
        {
            return NativeCalls.godot_icall_0_232(method_bind_60, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_ring_radius");

        [GodotMethod("set_emission_ring_radius")]
        [Obsolete("SetEmissionRingRadius is deprecated. Use the EmissionRingRadius property instead.")]
        public void SetEmissionRingRadius(float radius)
        {
            NativeCalls.godot_icall_1_15(method_bind_61, Object.GetPtr(this), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_ring_radius");

        [GodotMethod("get_emission_ring_radius")]
        [Obsolete("GetEmissionRingRadius is deprecated. Use the EmissionRingRadius property instead.")]
        public float GetEmissionRingRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_62, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_ring_inner_radius");

        [GodotMethod("set_emission_ring_inner_radius")]
        [Obsolete("SetEmissionRingInnerRadius is deprecated. Use the EmissionRingInnerRadius property instead.")]
        public void SetEmissionRingInnerRadius(float offset)
        {
            NativeCalls.godot_icall_1_15(method_bind_63, Object.GetPtr(this), offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_64 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_ring_inner_radius");

        [GodotMethod("get_emission_ring_inner_radius")]
        [Obsolete("GetEmissionRingInnerRadius is deprecated. Use the EmissionRingInnerRadius property instead.")]
        public float GetEmissionRingInnerRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_64, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_65 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_ring_height");

        [GodotMethod("set_emission_ring_height")]
        [Obsolete("SetEmissionRingHeight is deprecated. Use the EmissionRingHeight property instead.")]
        public void SetEmissionRingHeight(float height)
        {
            NativeCalls.godot_icall_1_15(method_bind_65, Object.GetPtr(this), height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_66 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_ring_height");

        [GodotMethod("get_emission_ring_height")]
        [Obsolete("GetEmissionRingHeight is deprecated. Use the EmissionRingHeight property instead.")]
        public float GetEmissionRingHeight()
        {
            return NativeCalls.godot_icall_0_14(method_bind_66, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_67 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emission_ring_axis");

        [GodotMethod("set_emission_ring_axis")]
        [Obsolete("SetEmissionRingAxis is deprecated. Use the EmissionRingAxis property instead.")]
        public void SetEmissionRingAxis(Vector3 axis)
        {
            NativeCalls.godot_icall_1_148(method_bind_67, Object.GetPtr(this), ref axis);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_68 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_emission_ring_axis");

        [GodotMethod("get_emission_ring_axis")]
        [Obsolete("GetEmissionRingAxis is deprecated. Use the EmissionRingAxis property instead.")]
        public Vector3 GetEmissionRingAxis()
        {
            NativeCalls.godot_icall_0_8(method_bind_68, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_69 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gravity");

        [GodotMethod("get_gravity")]
        [Obsolete("GetGravity is deprecated. Use the Gravity property instead.")]
        public Vector3 GetGravity()
        {
            NativeCalls.godot_icall_0_8(method_bind_69, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_70 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gravity");

        [GodotMethod("set_gravity")]
        [Obsolete("SetGravity is deprecated. Use the Gravity property instead.")]
        public void SetGravity(Vector3 accelVec)
        {
            NativeCalls.godot_icall_1_148(method_bind_70, Object.GetPtr(this), ref accelVec);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_71 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "convert_from_particles");

        /// <summary>
        /// <para>Sets this node's properties to match a given <see cref="Godot.Particles"/> node with an assigned <see cref="Godot.ParticlesMaterial"/>.</para>
        /// </summary>
        [GodotMethod("convert_from_particles")]
        public void ConvertFromParticles(Node particles)
        {
            NativeCalls.godot_icall_1_53(method_bind_71, Object.GetPtr(this), Object.GetPtr(particles));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
