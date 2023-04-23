using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>When used directly in an <see cref="Godot.AudioStreamPlayer"/> node, <see cref="Godot.AudioStreamMicrophone"/> plays back microphone input in real-time. This can be used in conjunction with <see cref="Godot.AudioEffectCapture"/> to process the data or save it.</para>
    /// <para>Note:  must be <c>true</c> for audio input to work. See also that setting's description for caveats related to permissions and operating system privacy settings.</para>
    /// </summary>
    public partial class AudioStreamMicrophone : AudioStream
    {
        private const string nativeName = "AudioStreamMicrophone";

        public AudioStreamMicrophone() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioStreamMicrophone_Ctor(this);
        }

        internal AudioStreamMicrophone(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
