using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Allows scaling the speed of the animation (or reversing it) in any children nodes. Setting it to 0 will pause the animation.</para>
    /// </summary>
    public partial class AnimationNodeTimeScale : AnimationNode
    {
        private const string nativeName = "AnimationNodeTimeScale";

        public AnimationNodeTimeScale() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimationNodeTimeScale_Ctor(this);
        }

        internal AnimationNodeTimeScale(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
