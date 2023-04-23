using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base resource for audio bus. Applies an audio effect on the bus that the resource is applied on.</para>
    /// </summary>
    public abstract partial class AudioEffect : Resource
    {
        private const string nativeName = "AudioEffect";

        internal AudioEffect() {}

        internal AudioEffect(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
