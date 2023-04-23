using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This texture gives access to the camera texture provided by a <see cref="Godot.CameraFeed"/>.</para>
    /// <para>Note: Many cameras supply YCbCr images which need to be converted in a shader.</para>
    /// </summary>
    public partial class CameraTexture : Texture
    {
        /// <summary>
        /// <para>The ID of the <see cref="Godot.CameraFeed"/> for which we want to display the image.</para>
        /// </summary>
        public int CameraFeedId
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCameraFeedId();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCameraFeedId(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Which image within the <see cref="Godot.CameraFeed"/> we want access to, important if the camera image is split in a Y and CbCr component.</para>
        /// </summary>
        public CameraServer.FeedImage WhichFeed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWhichFeed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWhichFeed(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Convenience property that gives access to the active property of the <see cref="Godot.CameraFeed"/>.</para>
        /// </summary>
        public bool CameraIsActive
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCameraActive();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCameraActive(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CameraTexture";

        public CameraTexture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CameraTexture_Ctor(this);
        }

        internal CameraTexture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_camera_feed_id");

        [GodotMethod("set_camera_feed_id")]
        [Obsolete("SetCameraFeedId is deprecated. Use the CameraFeedId property instead.")]
        public void SetCameraFeedId(int feedId)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), feedId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_camera_feed_id");

        [GodotMethod("get_camera_feed_id")]
        [Obsolete("GetCameraFeedId is deprecated. Use the CameraFeedId property instead.")]
        public int GetCameraFeedId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_which_feed");

        [GodotMethod("set_which_feed")]
        [Obsolete("SetWhichFeed is deprecated. Use the WhichFeed property instead.")]
        public void SetWhichFeed(CameraServer.FeedImage whichFeed)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)whichFeed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_which_feed");

        [GodotMethod("get_which_feed")]
        [Obsolete("GetWhichFeed is deprecated. Use the WhichFeed property instead.")]
        public CameraServer.FeedImage GetWhichFeed()
        {
            return (CameraServer.FeedImage)NativeCalls.godot_icall_0_260(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_camera_active");

        [GodotMethod("set_camera_active")]
        [Obsolete("SetCameraActive is deprecated. Use the CameraIsActive property instead.")]
        public void SetCameraActive(bool active)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), active);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_camera_active");

        [GodotMethod("get_camera_active")]
        [Obsolete("GetCameraActive is deprecated. Use the CameraIsActive property instead.")]
        public bool GetCameraActive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
