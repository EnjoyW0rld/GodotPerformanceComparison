using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node can be used to cause a seek command to happen to any sub-children of the animation graph. Use this node type to play an <see cref="Godot.Animation"/> from the start or a certain playback position inside the <see cref="Godot.AnimationNodeBlendTree"/>. After setting the time and changing the animation playback, the seek node automatically goes into sleep mode on the next process frame by setting its <c>seek_position</c> value to <c>-1.0</c>.</para>
    /// <para><code>
    /// # Play child animation from the start.
    /// animation_tree.set("parameters/Seek/seek_position", 0.0)
    /// # Alternative syntax (same result as above).
    /// animation_tree["parameters/Seek/seek_position"] = 0.0
    /// 
    /// # Play child animation from 12 second timestamp.
    /// animation_tree.set("parameters/Seek/seek_position", 12.0)
    /// # Alternative syntax (same result as above).
    /// animation_tree["parameters/Seek/seek_position"] = 12.0
    /// </code></para>
    /// </summary>
    public partial class AnimationNodeTimeSeek : AnimationNode
    {
        private const string nativeName = "AnimationNodeTimeSeek";

        public AnimationNodeTimeSeek() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimationNodeTimeSeek_Ctor(this);
        }

        internal AnimationNodeTimeSeek(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
