using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Camera is a special node that displays what is visible from its current location. Cameras register themselves in the nearest <see cref="Godot.Viewport"/> node (when ascending the tree). Only one camera can be active per viewport. If no viewport is available ascending the tree, the camera will register in the global viewport. In other words, a camera just provides 3D display capabilities to a <see cref="Godot.Viewport"/>, and, without one, a scene registered in that <see cref="Godot.Viewport"/> (or higher viewports) can't be displayed.</para>
    /// </summary>
    public partial class Camera : Spatial
    {
        public enum KeepAspectEnum
        {
            /// <summary>
            /// <para>Preserves the horizontal aspect ratio; also known as Vert- scaling. This is usually the best option for projects running in portrait mode, as taller aspect ratios will benefit from a wider vertical FOV.</para>
            /// </summary>
            Width = 0,
            /// <summary>
            /// <para>Preserves the vertical aspect ratio; also known as Hor+ scaling. This is usually the best option for projects running in landscape mode, as wider aspect ratios will automatically benefit from a wider horizontal FOV.</para>
            /// </summary>
            Height = 1
        }

        public enum ProjectionEnum
        {
            /// <summary>
            /// <para>Perspective projection. Objects on the screen becomes smaller when they are far away.</para>
            /// </summary>
            Perspective = 0,
            /// <summary>
            /// <para>Orthogonal projection, also known as orthographic projection. Objects remain the same size on the screen no matter how far away they are.</para>
            /// </summary>
            Orthogonal = 1,
            /// <summary>
            /// <para>Frustum projection. This mode allows adjusting <see cref="Godot.Camera.FrustumOffset"/> to create "tilted frustum" effects.</para>
            /// </summary>
            Frustum = 2
        }

        public enum DopplerTrackingEnum
        {
            /// <summary>
            /// <para>Disables <a href="https://en.wikipedia.org/wiki/Doppler_effect">Doppler effect</a> simulation (default).</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Simulate <a href="https://en.wikipedia.org/wiki/Doppler_effect">Doppler effect</a> by tracking positions of objects that are changed in <c>_process</c>. Changes in the relative velocity of this camera compared to those objects affect how audio is perceived (changing the audio's <see cref="Godot.AudioStreamPlayer3D.PitchScale"/>).</para>
            /// </summary>
            IdleStep = 1,
            /// <summary>
            /// <para>Simulate <a href="https://en.wikipedia.org/wiki/Doppler_effect">Doppler effect</a> by tracking positions of objects that are changed in <c>_physics_process</c>. Changes in the relative velocity of this camera compared to those objects affect how audio is perceived (changing the audio's <see cref="Godot.AudioStreamPlayer3D.PitchScale"/>).</para>
            /// </summary>
            PhysicsStep = 2
        }

        /// <summary>
        /// <para>The axis to lock during <see cref="Godot.Camera.Fov"/>/<see cref="Godot.Camera.Size"/> adjustments. Can be either <see cref="Godot.Camera.KeepAspectEnum.Width"/> or <see cref="Godot.Camera.KeepAspectEnum.Height"/>.</para>
        /// </summary>
        public Camera.KeepAspectEnum KeepAspect
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetKeepAspectMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetKeepAspectMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The culling mask that describes which 3D render layers are rendered by this camera.</para>
        /// </summary>
        public uint CullMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCullMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCullMask(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.Environment"/> to use for this camera.</para>
        /// </summary>
        public Environment Environment
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEnvironment();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnvironment(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The horizontal (X) offset of the camera viewport.</para>
        /// </summary>
        public float HOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The vertical (Y) offset of the camera viewport.</para>
        /// </summary>
        public float VOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If not <see cref="Godot.Camera.DopplerTrackingEnum.Disabled"/>, this camera will simulate the <a href="https://en.wikipedia.org/wiki/Doppler_effect">Doppler effect</a> for objects changed in particular <c>_process</c> methods. The Doppler effect is only simulated for <see cref="Godot.AudioStreamPlayer3D"/> nodes that have <see cref="Godot.AudioStreamPlayer3D.DopplerTracking"/> set to a value other than <see cref="Godot.AudioStreamPlayer3D.DopplerTrackingEnum.Disabled"/>.</para>
        /// <para>Note: To toggle the Doppler effect preview in the editor, use the Perspective menu in the top-left corner of the 3D viewport and toggle Enable Doppler.</para>
        /// </summary>
        public Camera.DopplerTrackingEnum DopplerTracking
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDopplerTracking();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDopplerTracking(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The camera's projection mode. In <see cref="Godot.Camera.ProjectionEnum.Perspective"/> mode, objects' Z distance from the camera's local space scales their perceived size.</para>
        /// </summary>
        public Camera.ProjectionEnum Projection
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetProjection();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetProjection(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the ancestor <see cref="Godot.Viewport"/> is currently using this camera.</para>
        /// <para>If multiple cameras are in the scene, one will always be made current. For example, if two <see cref="Godot.Camera"/> nodes are present in the scene and only one is current, setting one camera's <see cref="Godot.Camera.Current"/> to <c>false</c> will cause the other camera to be made current.</para>
        /// </summary>
        public bool Current
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsCurrent();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCurrent(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The camera's field of view angle (in degrees). Only applicable in perspective mode. Since <see cref="Godot.Camera.KeepAspect"/> locks one axis, <c>fov</c> sets the other axis' field of view angle.</para>
        /// <para>For reference, the default vertical field of view value (<c>70.0</c>) is equivalent to a horizontal FOV of:</para>
        /// <para>- ~86.07 degrees in a 4:3 viewport</para>
        /// <para>- ~96.50 degrees in a 16:10 viewport</para>
        /// <para>- ~102.45 degrees in a 16:9 viewport</para>
        /// <para>- ~117.06 degrees in a 21:9 viewport</para>
        /// </summary>
        public float Fov
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFov();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFov(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The camera's size in meters measured as the diameter of the width or height, depending on <see cref="Godot.Camera.KeepAspect"/>. Only applicable in orthogonal and frustum modes.</para>
        /// </summary>
        public float Size
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The camera's frustum offset. This can be changed from the default to create "tilted frustum" effects such as <a href="https://zdoom.org/wiki/Y-shearing">Y-shearing</a>.</para>
        /// <para>Note: Only effective if <see cref="Godot.Camera.Projection"/> is <see cref="Godot.Camera.ProjectionEnum.Frustum"/>.</para>
        /// </summary>
        public Vector2 FrustumOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrustumOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrustumOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The distance to the near culling boundary for this camera relative to its local Z axis.</para>
        /// </summary>
        public float Near
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetZnear();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetZnear(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The distance to the far culling boundary for this camera relative to its local Z axis.</para>
        /// </summary>
        public float Far
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetZfar();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetZfar(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Camera";

        public Camera() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Camera_Ctor(this);
        }

        internal Camera(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "project_ray_normal");

        /// <summary>
        /// <para>Returns a normal vector in world space, that is the result of projecting a point on the <see cref="Godot.Viewport"/> rectangle by the inverse camera projection. This is useful for casting rays in the form of (origin, normal) for object intersection or picking.</para>
        /// </summary>
        [GodotMethod("project_ray_normal")]
        public Vector3 ProjectRayNormal(Vector2 screenPoint)
        {
            NativeCalls.godot_icall_1_244(method_bind_0, Object.GetPtr(this), ref screenPoint, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "project_local_ray_normal");

        /// <summary>
        /// <para>Returns a normal vector from the screen point location directed along the camera. Orthogonal cameras are normalized. Perspective cameras account for perspective, screen width/height, etc.</para>
        /// </summary>
        [GodotMethod("project_local_ray_normal")]
        public Vector3 ProjectLocalRayNormal(Vector2 screenPoint)
        {
            NativeCalls.godot_icall_1_244(method_bind_1, Object.GetPtr(this), ref screenPoint, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "project_ray_origin");

        /// <summary>
        /// <para>Returns a 3D position in world space, that is the result of projecting a point on the <see cref="Godot.Viewport"/> rectangle by the inverse camera projection. This is useful for casting rays in the form of (origin, normal) for object intersection or picking.</para>
        /// </summary>
        [GodotMethod("project_ray_origin")]
        public Vector3 ProjectRayOrigin(Vector2 screenPoint)
        {
            NativeCalls.godot_icall_1_244(method_bind_2, Object.GetPtr(this), ref screenPoint, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "unproject_position");

        /// <summary>
        /// <para>Returns the 2D coordinate in the <see cref="Godot.Viewport"/> rectangle that maps to the given 3D point in world space.</para>
        /// <para>Note: When using this to position GUI elements over a 3D viewport, use <see cref="Godot.Camera.IsPositionBehind"/> to prevent them from appearing if the 3D point is behind the camera:</para>
        /// <para><code>
        /// # This code block is part of a script that inherits from Spatial.
        /// # `control` is a reference to a node inheriting from Control.
        /// control.visible = not get_viewport().get_camera().is_position_behind(global_transform.origin)
        /// control.rect_position = get_viewport().get_camera().unproject_position(global_transform.origin)
        /// </code></para>
        /// </summary>
        [GodotMethod("unproject_position")]
        public Vector2 UnprojectPosition(Vector3 worldPoint)
        {
            NativeCalls.godot_icall_1_245(method_bind_3, Object.GetPtr(this), ref worldPoint, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_position_behind");

        /// <summary>
        /// <para>Returns <c>true</c> if the given position is behind the camera.</para>
        /// <para>Note: A position which returns <c>false</c> may still be outside the camera's field of view.</para>
        /// </summary>
        [GodotMethod("is_position_behind")]
        public bool IsPositionBehind(Vector3 worldPoint)
        {
            return NativeCalls.godot_icall_1_246(method_bind_4, Object.GetPtr(this), ref worldPoint);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "project_position");

        /// <summary>
        /// <para>Returns the 3D point in world space that maps to the given 2D coordinate in the <see cref="Godot.Viewport"/> rectangle on a plane that is the given <c>z_depth</c> distance into the scene away from the camera.</para>
        /// </summary>
        [GodotMethod("project_position")]
        public Vector3 ProjectPosition(Vector2 screenPoint, float zDepth)
        {
            NativeCalls.godot_icall_2_247(method_bind_5, Object.GetPtr(this), ref screenPoint, zDepth, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_perspective");

        /// <summary>
        /// <para>Sets the camera projection to perspective mode (see <see cref="Godot.Camera.ProjectionEnum.Perspective"/>), by specifying a <c>fov</c> (field of view) angle in degrees, and the <c>z_near</c> and <c>z_far</c> clip planes in world space units.</para>
        /// </summary>
        [GodotMethod("set_perspective")]
        public void SetPerspective(float fov, float zNear, float zFar)
        {
            NativeCalls.godot_icall_3_248(method_bind_6, Object.GetPtr(this), fov, zNear, zFar);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_orthogonal");

        /// <summary>
        /// <para>Sets the camera projection to orthogonal mode (see <see cref="Godot.Camera.ProjectionEnum.Orthogonal"/>), by specifying a <c>size</c>, and the <c>z_near</c> and <c>z_far</c> clip planes in world space units. (As a hint, 2D games often use this projection, with values specified in pixels.)</para>
        /// </summary>
        [GodotMethod("set_orthogonal")]
        public void SetOrthogonal(float size, float zNear, float zFar)
        {
            NativeCalls.godot_icall_3_248(method_bind_7, Object.GetPtr(this), size, zNear, zFar);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_frustum");

        /// <summary>
        /// <para>Sets the camera projection to frustum mode (see <see cref="Godot.Camera.ProjectionEnum.Frustum"/>), by specifying a <c>size</c>, an <c>offset</c>, and the <c>z_near</c> and <c>z_far</c> clip planes in world space units. See also <see cref="Godot.Camera.FrustumOffset"/>.</para>
        /// </summary>
        [GodotMethod("set_frustum")]
        public void SetFrustum(float size, Vector2 offset, float zNear, float zFar)
        {
            NativeCalls.godot_icall_4_249(method_bind_8, Object.GetPtr(this), size, ref offset, zNear, zFar);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "make_current");

        /// <summary>
        /// <para>Makes this camera the current camera for the <see cref="Godot.Viewport"/> (see class description). If the camera node is outside the scene tree, it will attempt to become current once it's added.</para>
        /// </summary>
        [GodotMethod("make_current")]
        public void MakeCurrent()
        {
            NativeCalls.godot_icall_0_3(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_current");

        /// <summary>
        /// <para>If this is the current camera, remove it from being current. If <c>enable_next</c> is <c>true</c>, request to make the next camera current, if any.</para>
        /// </summary>
        [GodotMethod("clear_current")]
        public void ClearCurrent(bool enableNext = true)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), enableNext);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_current");

        [GodotMethod("set_current")]
        [Obsolete("SetCurrent is deprecated. Use the Current property instead.")]
        public void SetCurrent(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_11, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_current");

        [GodotMethod("is_current")]
        [Obsolete("IsCurrent is deprecated. Use the Current property instead.")]
        public bool IsCurrent()
        {
            return NativeCalls.godot_icall_0_7(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_camera_transform");

        /// <summary>
        /// <para>Returns the transform of the camera plus the vertical (<see cref="Godot.Camera.VOffset"/>) and horizontal (<see cref="Godot.Camera.HOffset"/>) offsets; and any other adjustments made to the position and orientation of the camera by subclassed cameras such as <see cref="Godot.ClippedCamera"/>, <see cref="Godot.InterpolatedCamera"/> and <see cref="Godot.ARVRCamera"/>.</para>
        /// </summary>
        [GodotMethod("get_camera_transform")]
        public Transform GetCameraTransform()
        {
            NativeCalls.godot_icall_0_22(method_bind_13, Object.GetPtr(this), out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fov");

        [GodotMethod("get_fov")]
        [Obsolete("GetFov is deprecated. Use the Fov property instead.")]
        public float GetFov()
        {
            return NativeCalls.godot_icall_0_14(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frustum_offset");

        [GodotMethod("get_frustum_offset")]
        [Obsolete("GetFrustumOffset is deprecated. Use the FrustumOffset property instead.")]
        public Vector2 GetFrustumOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_15, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_size");

        [GodotMethod("get_size")]
        [Obsolete("GetSize is deprecated. Use the Size property instead.")]
        public float GetSize()
        {
            return NativeCalls.godot_icall_0_14(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_zfar");

        [GodotMethod("get_zfar")]
        [Obsolete("GetZfar is deprecated. Use the Far property instead.")]
        public float GetZfar()
        {
            return NativeCalls.godot_icall_0_14(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_znear");

        [GodotMethod("get_znear")]
        [Obsolete("GetZnear is deprecated. Use the Near property instead.")]
        public float GetZnear()
        {
            return NativeCalls.godot_icall_0_14(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fov");

        [GodotMethod("set_fov")]
        [Obsolete("SetFov is deprecated. Use the Fov property instead.")]
        public void SetFov(float fov)
        {
            NativeCalls.godot_icall_1_15(method_bind_19, Object.GetPtr(this), fov);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_frustum_offset");

        [GodotMethod("set_frustum_offset")]
        [Obsolete("SetFrustumOffset is deprecated. Use the FrustumOffset property instead.")]
        public void SetFrustumOffset(Vector2 frustumOffset)
        {
            NativeCalls.godot_icall_1_57(method_bind_20, Object.GetPtr(this), ref frustumOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_size");

        [GodotMethod("set_size")]
        [Obsolete("SetSize is deprecated. Use the Size property instead.")]
        public void SetSize(float size)
        {
            NativeCalls.godot_icall_1_15(method_bind_21, Object.GetPtr(this), size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_zfar");

        [GodotMethod("set_zfar")]
        [Obsolete("SetZfar is deprecated. Use the Far property instead.")]
        public void SetZfar(float zfar)
        {
            NativeCalls.godot_icall_1_15(method_bind_22, Object.GetPtr(this), zfar);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_znear");

        [GodotMethod("set_znear")]
        [Obsolete("SetZnear is deprecated. Use the Near property instead.")]
        public void SetZnear(float znear)
        {
            NativeCalls.godot_icall_1_15(method_bind_23, Object.GetPtr(this), znear);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_projection");

        [GodotMethod("get_projection")]
        [Obsolete("GetProjection is deprecated. Use the Projection property instead.")]
        public Camera.ProjectionEnum GetProjection()
        {
            return (Camera.ProjectionEnum)NativeCalls.godot_icall_0_250(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_projection");

        [GodotMethod("set_projection")]
        [Obsolete("SetProjection is deprecated. Use the Projection property instead.")]
        public void SetProjection(Camera.ProjectionEnum projection)
        {
            NativeCalls.godot_icall_1_4(method_bind_25, Object.GetPtr(this), (int)projection);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_h_offset");

        [GodotMethod("set_h_offset")]
        [Obsolete("SetHOffset is deprecated. Use the HOffset property instead.")]
        public void SetHOffset(float ofs)
        {
            NativeCalls.godot_icall_1_15(method_bind_26, Object.GetPtr(this), ofs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_h_offset");

        [GodotMethod("get_h_offset")]
        [Obsolete("GetHOffset is deprecated. Use the HOffset property instead.")]
        public float GetHOffset()
        {
            return NativeCalls.godot_icall_0_14(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_v_offset");

        [GodotMethod("set_v_offset")]
        [Obsolete("SetVOffset is deprecated. Use the VOffset property instead.")]
        public void SetVOffset(float ofs)
        {
            NativeCalls.godot_icall_1_15(method_bind_28, Object.GetPtr(this), ofs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_v_offset");

        [GodotMethod("get_v_offset")]
        [Obsolete("GetVOffset is deprecated. Use the VOffset property instead.")]
        public float GetVOffset()
        {
            return NativeCalls.godot_icall_0_14(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cull_mask");

        [GodotMethod("set_cull_mask")]
        [Obsolete("SetCullMask is deprecated. Use the CullMask property instead.")]
        public void SetCullMask(uint mask)
        {
            NativeCalls.godot_icall_1_187(method_bind_30, Object.GetPtr(this), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cull_mask");

        [GodotMethod("get_cull_mask")]
        [Obsolete("GetCullMask is deprecated. Use the CullMask property instead.")]
        public uint GetCullMask()
        {
            return NativeCalls.godot_icall_0_188(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_environment");

        [GodotMethod("set_environment")]
        [Obsolete("SetEnvironment is deprecated. Use the Environment property instead.")]
        public void SetEnvironment(Environment env)
        {
            NativeCalls.godot_icall_1_24(method_bind_32, Object.GetPtr(this), Object.GetPtr(env));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_environment");

        [GodotMethod("get_environment")]
        [Obsolete("GetEnvironment is deprecated. Use the Environment property instead.")]
        public Environment GetEnvironment()
        {
            return NativeCalls.godot_icall_0_251(method_bind_33, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_keep_aspect_mode");

        [GodotMethod("set_keep_aspect_mode")]
        [Obsolete("SetKeepAspectMode is deprecated. Use the KeepAspect property instead.")]
        public void SetKeepAspectMode(Camera.KeepAspectEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_34, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_keep_aspect_mode");

        [GodotMethod("get_keep_aspect_mode")]
        [Obsolete("GetKeepAspectMode is deprecated. Use the KeepAspect property instead.")]
        public Camera.KeepAspectEnum GetKeepAspectMode()
        {
            return (Camera.KeepAspectEnum)NativeCalls.godot_icall_0_252(method_bind_35, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_doppler_tracking");

        [GodotMethod("set_doppler_tracking")]
        [Obsolete("SetDopplerTracking is deprecated. Use the DopplerTracking property instead.")]
        public void SetDopplerTracking(Camera.DopplerTrackingEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_36, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_doppler_tracking");

        [GodotMethod("get_doppler_tracking")]
        [Obsolete("GetDopplerTracking is deprecated. Use the DopplerTracking property instead.")]
        public Camera.DopplerTrackingEnum GetDopplerTracking()
        {
            return (Camera.DopplerTrackingEnum)NativeCalls.godot_icall_0_253(method_bind_37, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frustum");

        /// <summary>
        /// <para>Returns the camera's frustum planes in world space units as an array of <see cref="Godot.Plane"/>s in the following order: near, far, left, top, right, bottom. Not to be confused with <see cref="Godot.Camera.FrustumOffset"/>.</para>
        /// </summary>
        [GodotMethod("get_frustum")]
        public Godot.Collections.Array GetFrustum()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_38, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_camera_rid");

        /// <summary>
        /// <para>Returns the camera's RID from the <see cref="Godot.VisualServer"/>.</para>
        /// </summary>
        [GodotMethod("get_camera_rid")]
        public RID GetCameraRid()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_39, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cull_mask_bit");

        /// <summary>
        /// <para>Enables or disables the given <c>layer</c> in the <see cref="Godot.Camera.CullMask"/>.</para>
        /// </summary>
        [GodotMethod("set_cull_mask_bit")]
        public void SetCullMaskBit(int layer, bool enable)
        {
            NativeCalls.godot_icall_2_23(method_bind_40, Object.GetPtr(this), layer, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cull_mask_bit");

        /// <summary>
        /// <para>Returns <c>true</c> if the given <c>layer</c> in the <see cref="Godot.Camera.CullMask"/> is enabled, <c>false</c> otherwise.</para>
        /// </summary>
        [GodotMethod("get_cull_mask_bit")]
        public bool GetCullMaskBit(int layer)
        {
            return NativeCalls.godot_icall_1_35(method_bind_41, Object.GetPtr(this), layer);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
