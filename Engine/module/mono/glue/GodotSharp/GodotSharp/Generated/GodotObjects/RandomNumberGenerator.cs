using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>RandomNumberGenerator is a class for generating pseudo-random numbers. It currently uses <a href="http://www.pcg-random.org/">PCG32</a>.</para>
    /// <para>Note: The underlying algorithm is an implementation detail. As a result, it should not be depended upon for reproducible random streams across Godot versions.</para>
    /// <para>To generate a random float number (within a given range) based on a time-dependant seed:</para>
    /// <para><code>
    /// var rng = RandomNumberGenerator.new()
    /// func _ready():
    ///     rng.randomize()
    ///     var my_random_number = rng.randf_range(-10.0, 10.0)
    /// </code></para>
    /// <para>Note: The default values of <see cref="Godot.RandomNumberGenerator.Seed"/> and <see cref="Godot.RandomNumberGenerator.State"/> properties are pseudo-random, and changes when calling <see cref="Godot.RandomNumberGenerator.Randomize"/>. The <c>0</c> value documented here is a placeholder, and not the actual default seed.</para>
    /// </summary>
    public partial class RandomNumberGenerator : Reference
    {
        /// <summary>
        /// <para>Initializes the random number generator state based on the given seed value. A given seed will give a reproducible sequence of pseudo-random numbers.</para>
        /// <para>Note: The RNG does not have an avalanche effect, and can output similar random streams given similar seeds. Consider using a hash function to improve your seed quality if they're sourced externally.</para>
        /// <para>Note: Setting this property produces a side effect of changing the internal <see cref="Godot.RandomNumberGenerator.State"/>, so make sure to initialize the seed before modifying the <see cref="Godot.RandomNumberGenerator.State"/>:</para>
        /// <para><code>
        /// var rng = RandomNumberGenerator.new()
        /// rng.seed = hash("Godot")
        /// rng.state = 100 # Restore to some previously saved state.
        /// </code></para>
        /// <para>Warning: the getter of this property returns the previous <see cref="Godot.RandomNumberGenerator.State"/>, and not the initial seed value, which is going to be fixed in Godot 4.0.</para>
        /// </summary>
        public ulong Seed
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
        /// <para>The current state of the random number generator. Save and restore this property to restore the generator to a previous state:</para>
        /// <para><code>
        /// var rng = RandomNumberGenerator.new()
        /// print(rng.randf())
        /// var saved_state = rng.state # Store current state.
        /// print(rng.randf()) # Advance internal state.
        /// rng.state = saved_state # Restore the state.
        /// print(rng.randf()) # Prints the same value as in previous.
        /// </code></para>
        /// <para>Note: Do not set state to arbitrary values, since the random number generator requires the state to have certain qualities to behave properly. It should only be set to values that came from the state property itself. To initialize the random number generator with arbitrary input, use <see cref="Godot.RandomNumberGenerator.Seed"/> instead.</para>
        /// </summary>
        public ulong State
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetState();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetState(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "RandomNumberGenerator";

        public RandomNumberGenerator() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RandomNumberGenerator_Ctor(this);
        }

        internal RandomNumberGenerator(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_seed");

        [GodotMethod("set_seed")]
        [Obsolete("SetSeed is deprecated. Use the Seed property instead.")]
        public void SetSeed(ulong seed)
        {
            NativeCalls.godot_icall_1_283(method_bind_0, Object.GetPtr(this), seed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_seed");

        [GodotMethod("get_seed")]
        [Obsolete("GetSeed is deprecated. Use the Seed property instead.")]
        public ulong GetSeed()
        {
            return NativeCalls.godot_icall_0_30(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_state");

        [GodotMethod("set_state")]
        [Obsolete("SetState is deprecated. Use the State property instead.")]
        public void SetState(ulong state)
        {
            NativeCalls.godot_icall_1_283(method_bind_2, Object.GetPtr(this), state);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_state");

        [GodotMethod("get_state")]
        [Obsolete("GetState is deprecated. Use the State property instead.")]
        public ulong GetState()
        {
            return NativeCalls.godot_icall_0_30(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "randi");

        /// <summary>
        /// <para>Generates a pseudo-random 32-bit unsigned integer between <c>0</c> and <c>4294967295</c> (inclusive).</para>
        /// </summary>
        [GodotMethod("randi")]
        public uint Randi()
        {
            return NativeCalls.godot_icall_0_188(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "randf");

        /// <summary>
        /// <para>Generates a pseudo-random float between <c>0.0</c> and <c>1.0</c> (inclusive).</para>
        /// </summary>
        [GodotMethod("randf")]
        public float Randf()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "randfn");

        /// <summary>
        /// <para>Generates a <a href="https://en.wikipedia.org/wiki/Normal_distribution">normally-distributed</a> pseudo-random number, using Box-Muller transform with the specified <c>mean</c> and a standard <c>deviation</c>. This is also called Gaussian distribution.</para>
        /// </summary>
        [GodotMethod("randfn")]
        public float Randfn(float mean = 0f, float deviation = 1f)
        {
            return NativeCalls.godot_icall_2_705(method_bind_6, Object.GetPtr(this), mean, deviation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "randf_range");

        /// <summary>
        /// <para>Generates a pseudo-random float between <c>from</c> and <c>to</c> (inclusive).</para>
        /// </summary>
        [GodotMethod("randf_range")]
        public float RandfRange(float from, float to)
        {
            return NativeCalls.godot_icall_2_705(method_bind_7, Object.GetPtr(this), from, to);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "randi_range");

        /// <summary>
        /// <para>Generates a pseudo-random 32-bit signed integer between <c>from</c> and <c>to</c> (inclusive).</para>
        /// </summary>
        [GodotMethod("randi_range")]
        public int RandiRange(int from, int to)
        {
            return NativeCalls.godot_icall_2_60(method_bind_8, Object.GetPtr(this), from, to);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "randomize");

        /// <summary>
        /// <para>Setups a time-based seed to generator.</para>
        /// </summary>
        [GodotMethod("randomize")]
        public void Randomize()
        {
            NativeCalls.godot_icall_0_3(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
