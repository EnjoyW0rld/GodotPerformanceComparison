using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The <see cref="Godot.CameraServer"/> keeps track of different cameras accessible in Godot. These are external cameras such as webcams or the cameras on your phone.</para>
    /// <para>It is notably used to provide AR modules with a video feed from the camera.</para>
    /// <para>Note: This class is currently only implemented on macOS and iOS. On other platforms, no <see cref="Godot.CameraFeed"/>s will be available.</para>
    /// </summary>
    public static partial class CameraServer
    {
        public enum FeedImage
        {
            /// <summary>
            /// <para>The RGBA camera image.</para>
            /// </summary>
            RgbaImage = 0,
            /// <summary>
            /// <para>The <a href="https://en.wikipedia.org/wiki/YCbCr">YCbCr</a> camera image.</para>
            /// </summary>
            YcbcrImage = 0,
            /// <summary>
            /// <para>The Y component camera image.</para>
            /// </summary>
            YImage = 0,
            /// <summary>
            /// <para>The CbCr component camera image.</para>
            /// </summary>
            CbcrImage = 1
        }

        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(CameraServer).Name);
                return singleton;
            }
        }

        private const string nativeName = "CameraServer";
        internal static IntPtr ptr = NativeCalls.godot_icall_CameraServer_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_feed");

        /// <summary>
        /// <para>Returns the <see cref="Godot.CameraFeed"/> corresponding to the camera with the given <c>index</c>.</para>
        /// </summary>
        [GodotMethod("get_feed")]
        public static CameraFeed GetFeed(int index)
        {
            return NativeCalls.godot_icall_1_259(method_bind_0, ptr, index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_feed_count");

        /// <summary>
        /// <para>Returns the number of <see cref="Godot.CameraFeed"/>s registered.</para>
        /// </summary>
        [GodotMethod("get_feed_count")]
        public static int GetFeedCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "feeds");

        /// <summary>
        /// <para>Returns an array of <see cref="Godot.CameraFeed"/>s.</para>
        /// </summary>
        [GodotMethod("feeds")]
        public static Godot.Collections.Array Feeds()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_2, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_feed");

        /// <summary>
        /// <para>Adds the camera <c>feed</c> to the camera server.</para>
        /// </summary>
        [GodotMethod("add_feed")]
        public static void AddFeed(CameraFeed feed)
        {
            NativeCalls.godot_icall_1_24(method_bind_3, ptr, Object.GetPtr(feed));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_feed");

        /// <summary>
        /// <para>Removes the specified camera <c>feed</c>.</para>
        /// </summary>
        [GodotMethod("remove_feed")]
        public static void RemoveFeed(CameraFeed feed)
        {
            NativeCalls.godot_icall_1_24(method_bind_4, ptr, Object.GetPtr(feed));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
