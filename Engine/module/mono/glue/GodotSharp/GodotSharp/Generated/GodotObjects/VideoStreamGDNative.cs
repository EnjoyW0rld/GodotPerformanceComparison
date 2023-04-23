using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.VideoStream"/> resource for video formats implemented via GDNative.</para>
    /// <para>It can be used via <a href="https://github.com/KidRigger/godot-videodecoder">godot-videodecoder</a> which uses the <a href="https://ffmpeg.org">FFmpeg</a> library.</para>
    /// </summary>
    public partial class VideoStreamGDNative : VideoStream
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

        private const string nativeName = "VideoStreamGDNative";

        public VideoStreamGDNative() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VideoStreamGDNative_Ctor(this);
        }

        internal VideoStreamGDNative(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_file");

        /// <summary>
        /// <para>Sets the video file that this <see cref="Godot.VideoStreamGDNative"/> resource handles. The supported extensions depend on the GDNative plugins used to expose video formats.</para>
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
        /// <para>Returns the video file handled by this <see cref="Godot.VideoStreamGDNative"/>.</para>
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
