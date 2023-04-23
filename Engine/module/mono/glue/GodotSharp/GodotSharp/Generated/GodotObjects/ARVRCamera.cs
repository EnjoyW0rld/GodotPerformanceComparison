using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This is a helper spatial node for our camera; note that, if stereoscopic rendering is applicable (VR-HMD), most of the camera properties are ignored, as the HMD information overrides them. The only properties that can be trusted are the near and far planes.</para>
    /// <para>The position and orientation of this node is automatically updated by the ARVR Server to represent the location of the HMD if such tracking is available and can thus be used by game logic. Note that, in contrast to the ARVR Controller, the render thread has access to the most up-to-date tracking data of the HMD and the location of the ARVRCamera can lag a few milliseconds behind what is used for rendering as a result.</para>
    /// </summary>
    public partial class ARVRCamera : Camera
    {
        private const string nativeName = "ARVRCamera";

        public ARVRCamera() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ARVRCamera_Ctor(this);
        }

        internal ARVRCamera(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
