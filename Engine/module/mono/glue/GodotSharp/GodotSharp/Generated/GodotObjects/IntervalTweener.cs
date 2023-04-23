using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.IntervalTweener"/> is used to make delays in a tweening sequence. See <see cref="Godot.SceneTreeTween.TweenInterval"/> for more usage information.</para>
    /// <para>Note: <see cref="Godot.SceneTreeTween.TweenInterval"/> is the only correct way to create <see cref="Godot.IntervalTweener"/>. Any <see cref="Godot.IntervalTweener"/> created manually will not function correctly.</para>
    /// </summary>
    public partial class IntervalTweener : Tweener
    {
        private const string nativeName = "IntervalTweener";

        public IntervalTweener() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_IntervalTweener_Ctor(this);
        }

        internal IntervalTweener(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
