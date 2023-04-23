using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Separator is a <see cref="Godot.Control"/> used for separating other controls. It's purely a visual decoration. Horizontal (<see cref="Godot.HSeparator"/>) and Vertical (<see cref="Godot.VSeparator"/>) versions are available.</para>
    /// </summary>
    public abstract partial class Separator : Control
    {
        private const string nativeName = "Separator";

        internal Separator() {}

        internal Separator(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
