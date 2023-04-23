using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.VideoStream"/> resource handling the <a href="https://www.theora.org/">Ogg Theora</a> video format with <c>.ogv</c> extension. The Theora codec is less efficient than <see cref="Godot.VideoStreamWebm"/>'s VP8 and VP9, but it requires less CPU resources to decode. The Theora codec is decoded on the CPU.</para>
    /// <para>Note: While Ogg Theora videos can also have an <c>.ogg</c> extension, you will have to rename the extension to <c>.ogv</c> to use those videos within Godot.</para>
    /// </summary>
    public partial class VideoStreamTheora : VideoStream
    {
        public string File
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFile();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFile(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VideoStreamTheora";

        public VideoStreamTheora() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VideoStreamTheora_Ctor(this);
        }

        internal VideoStreamTheora(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_file");

        /// <summary>
        /// <para>Sets the Ogg Theora video file that this <see cref="Godot.VideoStreamTheora"/> resource handles. The <c>file</c> name should have the <c>.ogv</c> extension.</para>
        /// </summary>
        [GodotMethod("set_file")]
        [Obsolete("SetFile is deprecated. Use the File property instead.")]
        public void SetFile(string file)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), file);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_file");

        /// <summary>
        /// <para>Returns the Ogg Theora video file handled by this <see cref="Godot.VideoStreamTheora"/>.</para>
        /// </summary>
        [GodotMethod("get_file")]
        [Obsolete("GetFile is deprecated. Use the File property instead.")]
        public string GetFile()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
