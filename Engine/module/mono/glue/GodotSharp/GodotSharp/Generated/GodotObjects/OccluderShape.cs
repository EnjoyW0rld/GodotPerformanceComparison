using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.Occluder"/>s can use any primitive shape derived from <see cref="Godot.OccluderShape"/>.</para>
    /// </summary>
    public abstract partial class OccluderShape : Resource
    {
        private const string nativeName = "OccluderShape";

        internal OccluderShape() {}

        internal OccluderShape(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
