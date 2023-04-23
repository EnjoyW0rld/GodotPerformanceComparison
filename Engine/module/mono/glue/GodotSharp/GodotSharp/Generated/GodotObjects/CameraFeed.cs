using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A camera feed gives you access to a single physical camera attached to your device. When enabled, Godot will start capturing frames from the camera which can then be used. See also <see cref="Godot.CameraServer"/>.</para>
    /// <para>Note: Many cameras will return YCbCr images which are split into two textures and need to be combined in a shader. Godot does this automatically for you if you set the environment to show the camera image in the background.</para>
    /// </summary>
    public partial class CameraFeed : Reference
    {
        public enum FeedDataType
        {
            /// <summary>
            /// <para>No image set for the feed.</para>
            /// </summary>
            Noimage = 0,
            /// <summary>
            /// <para>Feed supplies RGB images.</para>
            /// </summary>
            Rgb = 1,
            /// <summary>
            /// <para>Feed supplies YCbCr images that need to be converted to RGB.</para>
            /// </summary>
            Ycbcr = 2,
            /// <summary>
            /// <para>Feed supplies separate Y and CbCr images that need to be combined and converted to RGB.</para>
            /// </summary>
            YcbcrSep = 3
        }

        public enum FeedPosition
        {
            /// <summary>
            /// <para>Unspecified position.</para>
            /// </summary>
            Unspecified = 0,
            /// <summary>
            /// <para>Camera is mounted at the front of the device.</para>
            /// </summary>
            Front = 1,
            /// <summary>
            /// <para>Camera is mounted at the back of the device.</para>
            /// </summary>
            Back = 2
        }

        /// <summary>
        /// <para>If <c>true</c>, the feed is active.</para>
        /// </summary>
        public bool FeedIsActive
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsActive();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetActive(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The transform applied to the camera's image.</para>
        /// </summary>
        public Transform2D FeedTransform
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTransform();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTransform(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CameraFeed";

        public CameraFeed() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CameraFeed_Ctor(this);
        }

        internal CameraFeed(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_id");

        /// <summary>
        /// <para>Returns the unique ID for this feed.</para>
        /// </summary>
        [GodotMethod("get_id")]
        public int GetId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_name");

        /// <summary>
        /// <para>Returns the camera's name.</para>
        /// </summary>
        [GodotMethod("get_name")]
        public string GetName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_active");

        [GodotMethod("is_active")]
        [Obsolete("IsActive is deprecated. Use the FeedIsActive property instead.")]
        public bool IsActive()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_active");

        [GodotMethod("set_active")]
        [Obsolete("SetActive is deprecated. Use the FeedIsActive property instead.")]
        public void SetActive(bool active)
        {
            NativeCalls.godot_icall_1_16(method_bind_3, Object.GetPtr(this), active);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_position");

        /// <summary>
        /// <para>Returns the position of camera on the device.</para>
        /// </summary>
        [GodotMethod("get_position")]
        public CameraFeed.FeedPosition GetPosition()
        {
            return (CameraFeed.FeedPosition)NativeCalls.godot_icall_0_258(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transform");

        [GodotMethod("get_transform")]
        [Obsolete("GetTransform is deprecated. Use the FeedTransform property instead.")]
        public Transform2D GetTransform()
        {
            NativeCalls.godot_icall_0_221(method_bind_5, Object.GetPtr(this), out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_transform");

        [GodotMethod("set_transform")]
        [Obsolete("SetTransform is deprecated. Use the FeedTransform property instead.")]
        public void SetTransform(Transform2D transform)
        {
            NativeCalls.godot_icall_1_220(method_bind_6, Object.GetPtr(this), ref transform);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
