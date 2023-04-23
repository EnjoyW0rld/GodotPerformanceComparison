using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.VideoStream"/> resource handling the <a href="https://www.webmproject.org/">WebM</a> video format with <c>.webm</c> extension. Both the VP8 and VP9 codecs are supported. The VP8 and VP9 codecs are more efficient than <see cref="Godot.VideoStreamTheora"/>, but they require more CPU resources to decode (especially VP9). Both the VP8 and VP9 codecs are decoded on the CPU.</para>
    /// <para>Note: Alpha channel (also known as transparency) is not supported. The video will always appear to have a black background, even if it originally contains an alpha channel.</para>
    /// <para>Note: There are known bugs and performance issues with WebM video playback in Godot. If you run into problems, try using the Ogg Theora format instead: <see cref="Godot.VideoStreamTheora"/></para>
    /// </summary>
    public partial class VideoStreamWebm : VideoStream
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

        private const string nativeName = "VideoStreamWebm";

        public VideoStreamWebm() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VideoStreamWebm_Ctor(this);
        }

        internal VideoStreamWebm(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_file");

        /// <summary>
        /// <para>Sets the WebM video file that this <see cref="Godot.VideoStreamWebm"/> resource handles. The <c>file</c> name should have the <c>.webm</c> extension.</para>
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
        /// <para>Returns the WebM video file handled by this <see cref="Godot.VideoStreamWebm"/>.</para>
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
