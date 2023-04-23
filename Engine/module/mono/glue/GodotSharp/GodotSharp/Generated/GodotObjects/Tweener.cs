using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Tweeners are objects that perform a specific animating task, e.g. interpolating a property or calling a method at a given time. A <see cref="Godot.Tweener"/> can't be created manually, you need to use a dedicated method from <see cref="Godot.SceneTreeTween"/>.</para>
    /// </summary>
    public abstract partial class Tweener : Reference
    {
        private const string nativeName = "Tweener";

        internal Tweener() {}

        internal Tweener(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
