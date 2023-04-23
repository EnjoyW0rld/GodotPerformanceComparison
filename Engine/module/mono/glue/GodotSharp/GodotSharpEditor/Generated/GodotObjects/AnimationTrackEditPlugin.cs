using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class AnimationTrackEditPlugin : Reference
    {
        private const string nativeName = "AnimationTrackEditPlugin";

        public AnimationTrackEditPlugin() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_AnimationTrackEditPlugin_Ctor(this);
        }

        internal AnimationTrackEditPlugin(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
