using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base resource type for all video streams. Classes that derive from <see cref="Godot.VideoStream"/> can all be used as resource types to play back videos in <see cref="Godot.VideoPlayer"/>.</para>
    /// </summary>
    public abstract partial class VideoStream : Resource
    {
        private const string nativeName = "VideoStream";

        internal VideoStream() {}

        internal VideoStream(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
