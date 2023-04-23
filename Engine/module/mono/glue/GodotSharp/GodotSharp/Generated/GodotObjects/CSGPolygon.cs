using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>An array of 2D points is extruded to quickly and easily create a variety of 3D meshes. See also <see cref="Godot.CSGMesh"/> for using 3D meshes as CSG nodes.</para>
    /// <para>Note: CSG nodes are intended to be used for level prototyping. Creating CSG nodes has a significant CPU cost compared to creating a <see cref="Godot.MeshInstance"/> with a <see cref="Godot.PrimitiveMesh"/>. Moving a CSG node within another CSG node also has a significant CPU cost, so it should be avoided during gameplay.</para>
    /// </summary>
    public partial class CSGPolygon : CSGPrimitive
    {
        public enum PathIntervalTypeEnum
        {
            /// <summary>
            /// <para>When <see cref="Godot.CSGPolygon.Mode"/> is set to <see cref="Godot.CSGPolygon.ModeEnum.Path"/>, <see cref="Godot.CSGPolygon.PathInterval"/> will determine the distance, in meters, each interval of the path will extrude.</para>
            /// </summary>
            Distance = 0,
            /// <summary>
            /// <para>When <see cref="Godot.CSGPolygon.Mode"/> is set to <see cref="Godot.CSGPolygon.ModeEnum.Path"/>, <see cref="Godot.CSGPolygon.PathInterval"/> will subdivide the polygons along the path.</para>
            /// </summary>
            Subdivide = 1
        }

        public enum PathRotationEnum
        {
            /// <summary>
            /// <para>The <see cref="Godot.CSGPolygon.Polygon"/> shape is not rotated.</para>
            /// <para>Note: Requires the path's Z coordinates to continually decrease to ensure viable shapes.</para>
            /// </summary>
            Polygon = 0,
            /// <summary>
            /// <para>The <see cref="Godot.CSGPolygon.Polygon"/> shape is rotated along the path, but it is not rotated around the path axis.</para>
            /// <para>Note: Requires the path's Z coordinates to continually decrease to ensure viable shapes.</para>
            /// </summary>
            Path = 1,
            /// <summary>
            /// <para>The <see cref="Godot.CSGPolygon.Polygon"/> shape follows the path and its rotations around the path axis.</para>
            /// </summary>
            PathFollow = 2
        }

        public enum ModeEnum
        {
            /// <summary>
            /// <para>The <see cref="Godot.CSGPolygon.Polygon"/> shape is extruded along the negative Z axis.</para>
            /// </summary>
            Depth = 0,
            /// <summary>
            /// <para>The <see cref="Godot.CSGPolygon.Polygon"/> shape is extruded by rotating it around the Y axis.</para>
            /// </summary>
            Spin = 1,
            /// <summary>
            /// <para>The <see cref="Godot.CSGPolygon.Polygon"/> shape is extruded along the <see cref="Godot.Path"/> specified in <see cref="Godot.CSGPolygon.PathNode"/>.</para>
            /// </summary>
            Path = 2
        }

        /// <summary>
        /// <para>The point array that defines the 2D polygon that is extruded. This can be a convex or concave polygon with 3 or more points. The polygon must not have any intersecting edges. Otherwise, triangulation will fail and no mesh will be generated.</para>
        /// <para>Note: If only 1 or 2 points are defined in <see cref="Godot.CSGPolygon.Polygon"/>, no mesh will be generated.</para>
        /// </summary>
        public Vector2[] Polygon
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPolygon();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPolygon(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.CSGPolygon.Mode"/> used to extrude the <see cref="Godot.CSGPolygon.Polygon"/>.</para>
        /// </summary>
        public CSGPolygon.ModeEnum Mode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When <see cref="Godot.CSGPolygon.Mode"/> is <see cref="Godot.CSGPolygon.ModeEnum.Depth"/>, the depth of the extrusion.</para>
        /// </summary>
        public float Depth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDepth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDepth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When <see cref="Godot.CSGPolygon.Mode"/> is <see cref="Godot.CSGPolygon.ModeEnum.Spin"/>, the total number of degrees the <see cref="Godot.CSGPolygon.Polygon"/> is rotated when extruding.</para>
        /// </summary>
        public float SpinDegrees
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpinDegrees();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpinDegrees(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When <see cref="Godot.CSGPolygon.Mode"/> is <see cref="Godot.CSGPolygon.ModeEnum.Spin"/>, the number of extrusions made.</para>
        /// </summary>
        public int SpinSides
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpinSides();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpinSides(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When <see cref="Godot.CSGPolygon.Mode"/> is <see cref="Godot.CSGPolygon.ModeEnum.Path"/>, the location of the <see cref="Godot.Path"/> object used to extrude the <see cref="Godot.CSGPolygon.Polygon"/>.</para>
        /// </summary>
        public NodePath PathNode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPathNode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPathNode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When <see cref="Godot.CSGPolygon.Mode"/> is <see cref="Godot.CSGPolygon.ModeEnum.Path"/>, this will determine if the interval should be by distance (<see cref="Godot.CSGPolygon.PathIntervalTypeEnum.Distance"/>) or subdivision fractions (<see cref="Godot.CSGPolygon.PathIntervalTypeEnum.Subdivide"/>).</para>
        /// </summary>
        public CSGPolygon.PathIntervalTypeEnum PathIntervalType
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPathIntervalType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPathIntervalType(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When <see cref="Godot.CSGPolygon.Mode"/> is <see cref="Godot.CSGPolygon.ModeEnum.Path"/>, the path interval or ratio of path points to extrusions.</para>
        /// </summary>
        public float PathInterval
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPathInterval();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPathInterval(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When <see cref="Godot.CSGPolygon.Mode"/> is <see cref="Godot.CSGPolygon.ModeEnum.Path"/>, extrusions that are less than this angle, will be merged together to reduce polygon count.</para>
        /// </summary>
        public float PathSimplifyAngle
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPathSimplifyAngle();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPathSimplifyAngle(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When <see cref="Godot.CSGPolygon.Mode"/> is <see cref="Godot.CSGPolygon.ModeEnum.Path"/>, the <see cref="Godot.CSGPolygon.PathRotationEnum"/> method used to rotate the <see cref="Godot.CSGPolygon.Polygon"/> as it is extruded.</para>
        /// </summary>
        public CSGPolygon.PathRotationEnum PathRotation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPathRotation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPathRotation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When <see cref="Godot.CSGPolygon.Mode"/> is <see cref="Godot.CSGPolygon.ModeEnum.Path"/>, if <c>true</c> the <see cref="Godot.Transform"/> of the <see cref="Godot.CSGPolygon"/> is used as the starting point for the extrusions, not the <see cref="Godot.Transform"/> of the <see cref="Godot.CSGPolygon.PathNode"/>.</para>
        /// </summary>
        public bool PathLocal
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPathLocal();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPathLocal(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When <see cref="Godot.CSGPolygon.Mode"/> is <see cref="Godot.CSGPolygon.ModeEnum.Path"/>, by default, the top half of the <see cref="Godot.CSGPolygon.Material"/> is stretched along the entire length of the extruded shape. If <c>false</c> the top half of the material is repeated every step of the extrusion.</para>
        /// </summary>
        public bool PathContinuousU
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPathContinuousU();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPathContinuousU(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When <see cref="Godot.CSGPolygon.Mode"/> is <see cref="Godot.CSGPolygon.ModeEnum.Path"/>, this is the distance along the path, in meters, the texture coordinates will tile. When set to 0, texture coordinates will match geometry exactly with no tiling.</para>
        /// </summary>
        public float PathUDistance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPathUDistance();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPathUDistance(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>When <see cref="Godot.CSGPolygon.Mode"/> is <see cref="Godot.CSGPolygon.ModeEnum.Path"/>, if <c>true</c> the ends of the path are joined, by adding an extrusion between the last and first points of the path.</para>
        /// </summary>
        public bool PathJoined
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPathJoined();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPathJoined(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, applies smooth shading to the extrusions.</para>
        /// </summary>
        public bool SmoothFaces
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSmoothFaces();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSmoothFaces(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Material to use for the resulting mesh. The UV maps the top half of the material to the extruded shape (U along the the length of the extrusions and V around the outline of the <see cref="Godot.CSGPolygon.Polygon"/>), the bottom-left quarter to the front end face, and the bottom-right quarter to the back end face.</para>
        /// </summary>
        public Material Material
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaterial();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaterial(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CSGPolygon";

        public CSGPolygon() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CSGPolygon_Ctor(this);
        }

        internal CSGPolygon(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_polygon");

        [GodotMethod("set_polygon")]
        [Obsolete("SetPolygon is deprecated. Use the Polygon property instead.")]
        public void SetPolygon(Vector2[] polygon)
        {
            NativeCalls.godot_icall_1_235(method_bind_0, Object.GetPtr(this), polygon);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_polygon");

        [GodotMethod("get_polygon")]
        [Obsolete("GetPolygon is deprecated. Use the Polygon property instead.")]
        public Vector2[] GetPolygon()
        {
            return NativeCalls.godot_icall_0_236(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mode");

        [GodotMethod("set_mode")]
        [Obsolete("SetMode is deprecated. Use the Mode property instead.")]
        public void SetMode(CSGPolygon.ModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mode");

        [GodotMethod("get_mode")]
        [Obsolete("GetMode is deprecated. Use the Mode property instead.")]
        public CSGPolygon.ModeEnum GetMode()
        {
            return (CSGPolygon.ModeEnum)NativeCalls.godot_icall_0_238(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_depth");

        [GodotMethod("set_depth")]
        [Obsolete("SetDepth is deprecated. Use the Depth property instead.")]
        public void SetDepth(float depth)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), depth);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_depth");

        [GodotMethod("get_depth")]
        [Obsolete("GetDepth is deprecated. Use the Depth property instead.")]
        public float GetDepth()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_spin_degrees");

        [GodotMethod("set_spin_degrees")]
        [Obsolete("SetSpinDegrees is deprecated. Use the SpinDegrees property instead.")]
        public void SetSpinDegrees(float degrees)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), degrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_spin_degrees");

        [GodotMethod("get_spin_degrees")]
        [Obsolete("GetSpinDegrees is deprecated. Use the SpinDegrees property instead.")]
        public float GetSpinDegrees()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_spin_sides");

        [GodotMethod("set_spin_sides")]
        [Obsolete("SetSpinSides is deprecated. Use the SpinSides property instead.")]
        public void SetSpinSides(int spinSides)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), spinSides);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_spin_sides");

        [GodotMethod("get_spin_sides")]
        [Obsolete("GetSpinSides is deprecated. Use the SpinSides property instead.")]
        public int GetSpinSides()
        {
            return NativeCalls.godot_icall_0_5(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_path_node");

        [GodotMethod("set_path_node")]
        [Obsolete("SetPathNode is deprecated. Use the PathNode property instead.")]
        public void SetPathNode(NodePath path)
        {
            NativeCalls.godot_icall_1_129(method_bind_10, Object.GetPtr(this), NodePath.GetPtr(path));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_path_node");

        [GodotMethod("get_path_node")]
        [Obsolete("GetPathNode is deprecated. Use the PathNode property instead.")]
        public NodePath GetPathNode()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_11, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_path_interval_type");

        [GodotMethod("set_path_interval_type")]
        [Obsolete("SetPathIntervalType is deprecated. Use the PathIntervalType property instead.")]
        public void SetPathIntervalType(CSGPolygon.PathIntervalTypeEnum intervalType)
        {
            NativeCalls.godot_icall_1_4(method_bind_12, Object.GetPtr(this), (int)intervalType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_path_interval_type");

        [GodotMethod("get_path_interval_type")]
        [Obsolete("GetPathIntervalType is deprecated. Use the PathIntervalType property instead.")]
        public CSGPolygon.PathIntervalTypeEnum GetPathIntervalType()
        {
            return (CSGPolygon.PathIntervalTypeEnum)NativeCalls.godot_icall_0_239(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_path_interval");

        [GodotMethod("set_path_interval")]
        [Obsolete("SetPathInterval is deprecated. Use the PathInterval property instead.")]
        public void SetPathInterval(float pathInterval)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), pathInterval);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_path_interval");

        [GodotMethod("get_path_interval")]
        [Obsolete("GetPathInterval is deprecated. Use the PathInterval property instead.")]
        public float GetPathInterval()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_path_simplify_angle");

        [GodotMethod("set_path_simplify_angle")]
        [Obsolete("SetPathSimplifyAngle is deprecated. Use the PathSimplifyAngle property instead.")]
        public void SetPathSimplifyAngle(float degrees)
        {
            NativeCalls.godot_icall_1_15(method_bind_16, Object.GetPtr(this), degrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_path_simplify_angle");

        [GodotMethod("get_path_simplify_angle")]
        [Obsolete("GetPathSimplifyAngle is deprecated. Use the PathSimplifyAngle property instead.")]
        public float GetPathSimplifyAngle()
        {
            return NativeCalls.godot_icall_0_14(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_path_rotation");

        [GodotMethod("set_path_rotation")]
        [Obsolete("SetPathRotation is deprecated. Use the PathRotation property instead.")]
        public void SetPathRotation(CSGPolygon.PathRotationEnum pathRotation)
        {
            NativeCalls.godot_icall_1_4(method_bind_18, Object.GetPtr(this), (int)pathRotation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_path_rotation");

        [GodotMethod("get_path_rotation")]
        [Obsolete("GetPathRotation is deprecated. Use the PathRotation property instead.")]
        public CSGPolygon.PathRotationEnum GetPathRotation()
        {
            return (CSGPolygon.PathRotationEnum)NativeCalls.godot_icall_0_240(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_path_local");

        [GodotMethod("set_path_local")]
        [Obsolete("SetPathLocal is deprecated. Use the PathLocal property instead.")]
        public void SetPathLocal(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_20, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_path_local");

        [GodotMethod("is_path_local")]
        [Obsolete("IsPathLocal is deprecated. Use the PathLocal property instead.")]
        public bool IsPathLocal()
        {
            return NativeCalls.godot_icall_0_7(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_path_continuous_u");

        [GodotMethod("set_path_continuous_u")]
        [Obsolete("SetPathContinuousU is deprecated. Use the PathContinuousU property instead.")]
        public void SetPathContinuousU(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_22, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_path_continuous_u");

        [GodotMethod("is_path_continuous_u")]
        [Obsolete("IsPathContinuousU is deprecated. Use the PathContinuousU property instead.")]
        public bool IsPathContinuousU()
        {
            return NativeCalls.godot_icall_0_7(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_path_u_distance");

        [GodotMethod("set_path_u_distance")]
        [Obsolete("SetPathUDistance is deprecated. Use the PathUDistance property instead.")]
        public void SetPathUDistance(float distance)
        {
            NativeCalls.godot_icall_1_15(method_bind_24, Object.GetPtr(this), distance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_path_u_distance");

        [GodotMethod("get_path_u_distance")]
        [Obsolete("GetPathUDistance is deprecated. Use the PathUDistance property instead.")]
        public float GetPathUDistance()
        {
            return NativeCalls.godot_icall_0_14(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_path_joined");

        [GodotMethod("set_path_joined")]
        [Obsolete("SetPathJoined is deprecated. Use the PathJoined property instead.")]
        public void SetPathJoined(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_26, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_path_joined");

        [GodotMethod("is_path_joined")]
        [Obsolete("IsPathJoined is deprecated. Use the PathJoined property instead.")]
        public bool IsPathJoined()
        {
            return NativeCalls.godot_icall_0_7(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_material");

        [GodotMethod("set_material")]
        [Obsolete("SetMaterial is deprecated. Use the Material property instead.")]
        public void SetMaterial(Material material)
        {
            NativeCalls.godot_icall_1_24(method_bind_28, Object.GetPtr(this), Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_material");

        [GodotMethod("get_material")]
        [Obsolete("GetMaterial is deprecated. Use the Material property instead.")]
        public Material GetMaterial()
        {
            return NativeCalls.godot_icall_0_237(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_smooth_faces");

        [GodotMethod("set_smooth_faces")]
        [Obsolete("SetSmoothFaces is deprecated. Use the SmoothFaces property instead.")]
        public void SetSmoothFaces(bool smoothFaces)
        {
            NativeCalls.godot_icall_1_16(method_bind_30, Object.GetPtr(this), smoothFaces);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_smooth_faces");

        [GodotMethod("get_smooth_faces")]
        [Obsolete("GetSmoothFaces is deprecated. Use the SmoothFaces property instead.")]
        public bool GetSmoothFaces()
        {
            return NativeCalls.godot_icall_0_7(method_bind_31, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
