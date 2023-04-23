using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>MultiMesh provides low-level mesh instancing. Drawing thousands of <see cref="Godot.MeshInstance"/> nodes can be slow, since each object is submitted to the GPU then drawn individually.</para>
    /// <para>MultiMesh is much faster as it can draw thousands of instances with a single draw call, resulting in less API overhead.</para>
    /// <para>As a drawback, if the instances are too far away from each other, performance may be reduced as every single instance will always render (they are spatially indexed as one, for the whole object).</para>
    /// <para>Since instances may have any behavior, the AABB used for visibility must be provided by the user.</para>
    /// </summary>
    public partial class MultiMesh : Resource
    {
        public enum PhysicsInterpolationQualityEnum
        {
            /// <summary>
            /// <para>Always interpolate using Basis lerping, which can produce warping artifacts in some situations.</para>
            /// </summary>
            Fast = 0,
            /// <summary>
            /// <para>Attempt to interpolate using Basis slerping (spherical linear interpolation) where possible, otherwise fall back to lerping.</para>
            /// </summary>
            High = 1
        }

        public enum TransformFormatEnum
        {
            /// <summary>
            /// <para>Use this when using 2D transforms.</para>
            /// </summary>
            Transform2d = 0,
            /// <summary>
            /// <para>Use this when using 3D transforms.</para>
            /// </summary>
            Transform3d = 1
        }

        public enum CustomDataFormatEnum
        {
            /// <summary>
            /// <para>Use when you are not using per-instance custom data.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>Compress custom_data into 8 bits when passing to shader. This uses less memory and can be faster, but loses precision and range. Floats packed into 8 bits can only represent values between 0 and 1, numbers outside that range will be clamped.</para>
            /// </summary>
            Data8bit = 1,
            /// <summary>
            /// <para>The <see cref="Godot.Color"/> passed into <see cref="Godot.MultiMesh.SetInstanceCustomData"/> will use 4 floats. Use this for highest precision.</para>
            /// </summary>
            Float = 2
        }

        public enum ColorFormatEnum
        {
            /// <summary>
            /// <para>Use when you are not using per-instance <see cref="Godot.Color"/>s.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>Compress <see cref="Godot.Color"/> data into 8 bits when passing to shader. This uses less memory and can be faster, but the <see cref="Godot.Color"/> loses precision.</para>
            /// </summary>
            Color8bit = 1,
            /// <summary>
            /// <para>The <see cref="Godot.Color"/> passed into <see cref="Godot.MultiMesh.SetInstanceColor"/> will use 4 floats. Use this for highest precision <see cref="Godot.Color"/>.</para>
            /// </summary>
            Float = 2
        }

        /// <summary>
        /// <para>Format of colors in color array that gets passed to shader.</para>
        /// </summary>
        public MultiMesh.ColorFormatEnum ColorFormat
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColorFormat();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetColorFormat(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Format of transform used to transform mesh, either 2D or 3D.</para>
        /// </summary>
        public MultiMesh.TransformFormatEnum TransformFormat
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTransformFormat();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTransformFormat(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Format of custom data in custom data array that gets passed to shader.</para>
        /// </summary>
        public MultiMesh.CustomDataFormatEnum CustomDataFormat
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCustomDataFormat();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCustomDataFormat(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Number of instances that will get drawn. This clears and (re)sizes the buffers. By default, all instances are drawn but you can limit this with <see cref="Godot.MultiMesh.VisibleInstanceCount"/>.</para>
        /// </summary>
        public int InstanceCount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInstanceCount();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInstanceCount(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Limits the number of instances drawn, -1 draws all instances. Changing this does not change the sizes of the buffers.</para>
        /// </summary>
        public int VisibleInstanceCount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVisibleInstanceCount();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVisibleInstanceCount(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Mesh to be drawn.</para>
        /// </summary>
        public Mesh Mesh
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMesh();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMesh(value);
            }
#pragma warning restore CS0618
        }

        public Vector3[] TransformArray
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetTransformArray();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetTransformArray(value);
            }
#pragma warning restore CS0618
        }

        public Vector2[] Transform2dArray
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetTransform2dArray();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetTransform2dArray(value);
            }
#pragma warning restore CS0618
        }

        public Color[] ColorArray
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetColorArray();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetColorArray(value);
            }
#pragma warning restore CS0618
        }

        public Color[] CustomDataArray
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetCustomDataArray();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetCustomDataArray(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Choose whether to use an interpolation method that favors speed or quality.</para>
        /// <para>When using low physics tick rates (typically below 20) or high rates of object rotation, you may get better results from the high quality setting.</para>
        /// <para>Note: Fast quality does not equate to low quality. Except in the special cases mentioned above, the quality should be comparable to high quality.</para>
        /// </summary>
        public MultiMesh.PhysicsInterpolationQualityEnum PhysicsInterpolationQuality
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPhysicsInterpolationQuality();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPhysicsInterpolationQuality(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "MultiMesh";

        public MultiMesh() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MultiMesh_Ctor(this);
        }

        internal MultiMesh(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mesh");

        [GodotMethod("set_mesh")]
        [Obsolete("SetMesh is deprecated. Use the Mesh property instead.")]
        public void SetMesh(Mesh mesh)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(mesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mesh");

        [GodotMethod("get_mesh")]
        [Obsolete("GetMesh is deprecated. Use the Mesh property instead.")]
        public Mesh GetMesh()
        {
            return NativeCalls.godot_icall_0_10(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color_format");

        [GodotMethod("set_color_format")]
        [Obsolete("SetColorFormat is deprecated. Use the ColorFormat property instead.")]
        public void SetColorFormat(MultiMesh.ColorFormatEnum format)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)format);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color_format");

        [GodotMethod("get_color_format")]
        [Obsolete("GetColorFormat is deprecated. Use the ColorFormat property instead.")]
        public MultiMesh.ColorFormatEnum GetColorFormat()
        {
            return (MultiMesh.ColorFormatEnum)NativeCalls.godot_icall_0_613(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_data_format");

        [GodotMethod("set_custom_data_format")]
        [Obsolete("SetCustomDataFormat is deprecated. Use the CustomDataFormat property instead.")]
        public void SetCustomDataFormat(MultiMesh.CustomDataFormatEnum format)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), (int)format);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_custom_data_format");

        [GodotMethod("get_custom_data_format")]
        [Obsolete("GetCustomDataFormat is deprecated. Use the CustomDataFormat property instead.")]
        public MultiMesh.CustomDataFormatEnum GetCustomDataFormat()
        {
            return (MultiMesh.CustomDataFormatEnum)NativeCalls.godot_icall_0_614(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_transform_format");

        [GodotMethod("set_transform_format")]
        [Obsolete("SetTransformFormat is deprecated. Use the TransformFormat property instead.")]
        public void SetTransformFormat(MultiMesh.TransformFormatEnum format)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), (int)format);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transform_format");

        [GodotMethod("get_transform_format")]
        [Obsolete("GetTransformFormat is deprecated. Use the TransformFormat property instead.")]
        public MultiMesh.TransformFormatEnum GetTransformFormat()
        {
            return (MultiMesh.TransformFormatEnum)NativeCalls.godot_icall_0_615(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_instance_count");

        [GodotMethod("set_instance_count")]
        [Obsolete("SetInstanceCount is deprecated. Use the InstanceCount property instead.")]
        public void SetInstanceCount(int count)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), count);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_instance_count");

        [GodotMethod("get_instance_count")]
        [Obsolete("GetInstanceCount is deprecated. Use the InstanceCount property instead.")]
        public int GetInstanceCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_visible_instance_count");

        [GodotMethod("set_visible_instance_count")]
        [Obsolete("SetVisibleInstanceCount is deprecated. Use the VisibleInstanceCount property instead.")]
        public void SetVisibleInstanceCount(int count)
        {
            NativeCalls.godot_icall_1_4(method_bind_10, Object.GetPtr(this), count);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_visible_instance_count");

        [GodotMethod("get_visible_instance_count")]
        [Obsolete("GetVisibleInstanceCount is deprecated. Use the VisibleInstanceCount property instead.")]
        public int GetVisibleInstanceCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_physics_interpolation_quality");

        [GodotMethod("set_physics_interpolation_quality")]
        [Obsolete("SetPhysicsInterpolationQuality is deprecated. Use the PhysicsInterpolationQuality property instead.")]
        public void SetPhysicsInterpolationQuality(MultiMesh.PhysicsInterpolationQualityEnum quality)
        {
            NativeCalls.godot_icall_1_4(method_bind_12, Object.GetPtr(this), (int)quality);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_physics_interpolation_quality");

        [GodotMethod("get_physics_interpolation_quality")]
        [Obsolete("GetPhysicsInterpolationQuality is deprecated. Use the PhysicsInterpolationQuality property instead.")]
        public MultiMesh.PhysicsInterpolationQualityEnum GetPhysicsInterpolationQuality()
        {
            return (MultiMesh.PhysicsInterpolationQualityEnum)NativeCalls.godot_icall_0_616(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_instance_transform");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Transform"/> for a specific instance.</para>
        /// </summary>
        [GodotMethod("set_instance_transform")]
        public void SetInstanceTransform(int instance, Transform transform)
        {
            NativeCalls.godot_icall_2_606(method_bind_14, Object.GetPtr(this), instance, ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_instance_transform_2d");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Transform2D"/> for a specific instance.</para>
        /// </summary>
        [GodotMethod("set_instance_transform_2d")]
        public void SetInstanceTransform2d(int instance, Transform2D transform)
        {
            NativeCalls.godot_icall_2_617(method_bind_15, Object.GetPtr(this), instance, ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_instance_transform");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Transform"/> of a specific instance.</para>
        /// </summary>
        [GodotMethod("get_instance_transform")]
        public Transform GetInstanceTransform(int instance)
        {
            NativeCalls.godot_icall_1_609(method_bind_16, Object.GetPtr(this), instance, out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_instance_transform_2d");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Transform2D"/> of a specific instance.</para>
        /// </summary>
        [GodotMethod("get_instance_transform_2d")]
        public Transform2D GetInstanceTransform2d(int instance)
        {
            NativeCalls.godot_icall_1_618(method_bind_17, Object.GetPtr(this), instance, out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_instance_color");

        /// <summary>
        /// <para>Sets the color of a specific instance by multiplying the mesh's existing vertex colors.</para>
        /// <para>For the color to take effect, ensure that <see cref="Godot.MultiMesh.ColorFormat"/> is non-<c>null</c> on the <see cref="Godot.MultiMesh"/> and <see cref="Godot.SpatialMaterial.VertexColorUseAsAlbedo"/> is <c>true</c> on the material. If the color doesn't look as expected, make sure the material's albedo color is set to pure white (<c>Color(1, 1, 1)</c>).</para>
        /// </summary>
        [GodotMethod("set_instance_color")]
        public void SetInstanceColor(int instance, Color color)
        {
            NativeCalls.godot_icall_2_464(method_bind_18, Object.GetPtr(this), instance, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_instance_color");

        /// <summary>
        /// <para>Gets a specific instance's color.</para>
        /// </summary>
        [GodotMethod("get_instance_color")]
        public Color GetInstanceColor(int instance)
        {
            NativeCalls.godot_icall_1_465(method_bind_19, Object.GetPtr(this), instance, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_instance_custom_data");

        /// <summary>
        /// <para>Sets custom data for a specific instance. Although <see cref="Godot.Color"/> is used, it is just a container for 4 floating point numbers. The format of the number can change depending on the <see cref="Godot.MultiMesh.CustomDataFormatEnum"/> used.</para>
        /// </summary>
        [GodotMethod("set_instance_custom_data")]
        public void SetInstanceCustomData(int instance, Color customData)
        {
            NativeCalls.godot_icall_2_464(method_bind_20, Object.GetPtr(this), instance, ref customData);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_instance_custom_data");

        /// <summary>
        /// <para>Returns the custom data that has been set for a specific instance.</para>
        /// </summary>
        [GodotMethod("get_instance_custom_data")]
        public Color GetInstanceCustomData(int instance)
        {
            NativeCalls.godot_icall_1_465(method_bind_21, Object.GetPtr(this), instance, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reset_instance_physics_interpolation");

        /// <summary>
        /// <para>When using physics interpolation, this function allows you to prevent interpolation on an instance in the current physics tick.</para>
        /// <para>This allows you to move instances instantaneously, and should usually be used when initially placing an instance such as a bullet to prevent graphical glitches.</para>
        /// </summary>
        [GodotMethod("reset_instance_physics_interpolation")]
        public void ResetInstancePhysicsInterpolation(int instance)
        {
            NativeCalls.godot_icall_1_4(method_bind_22, Object.GetPtr(this), instance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_as_bulk_array");

        /// <summary>
        /// <para>Sets all data related to the instances in one go. This is especially useful when loading the data from disk or preparing the data from GDNative.</para>
        /// <para>All data is packed in one large float array. An array may look like this: Transform for instance 1, color data for instance 1, custom data for instance 1, transform for instance 2, color data for instance 2, etc...</para>
        /// <para><see cref="Godot.Transform"/> is stored as 12 floats, <see cref="Godot.Transform2D"/> is stored as 8 floats, <c>COLOR_8BIT</c> / <c>CUSTOM_DATA_8BIT</c> is stored as 1 float (4 bytes as is) and <c>COLOR_FLOAT</c> / <c>CUSTOM_DATA_FLOAT</c> is stored as 4 floats.</para>
        /// </summary>
        [GodotMethod("set_as_bulk_array")]
        public void SetAsBulkArray(float[] array)
        {
            NativeCalls.godot_icall_1_452(method_bind_23, Object.GetPtr(this), array);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_as_bulk_array_interpolated");

        /// <summary>
        /// <para>An alternative version of <see cref="Godot.MultiMesh.SetAsBulkArray"/> which can be used with physics interpolation. This method takes two arrays, and can set the data for the current and previous tick in one go. The renderer will automatically interpolate the data at each frame.</para>
        /// <para>This is useful for situations where the order of instances may change from physics tick to tick, such as particle systems.</para>
        /// <para>When the order of instances is coherent, the simpler <see cref="Godot.MultiMesh.SetAsBulkArray"/> can still be used with interpolation.</para>
        /// </summary>
        [GodotMethod("set_as_bulk_array_interpolated")]
        public void SetAsBulkArrayInterpolated(float[] arrayCurrent, float[] arrayPrevious)
        {
            NativeCalls.godot_icall_2_619(method_bind_24, Object.GetPtr(this), arrayCurrent, arrayPrevious);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_aabb");

        /// <summary>
        /// <para>Returns the visibility axis-aligned bounding box in local space. See also <see cref="Godot.VisualInstance.GetTransformedAabb"/>.</para>
        /// </summary>
        [GodotMethod("get_aabb")]
        public AABB GetAabb()
        {
            NativeCalls.godot_icall_0_158(method_bind_25, Object.GetPtr(this), out AABB argRet); return (AABB)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_transform_array");

        [Obsolete("_SetTransformArray is deprecated. Use the TransformArray property instead.")]
        internal void _SetTransformArray(Vector3[] arg0)
        {
            NativeCalls.godot_icall_1_229(method_bind_26, Object.GetPtr(this), arg0);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_transform_array");

        [Obsolete("_GetTransformArray is deprecated. Use the TransformArray property instead.")]
        internal Vector3[] _GetTransformArray()
        {
            return NativeCalls.godot_icall_0_230(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_transform_2d_array");

        [Obsolete("_SetTransform2dArray is deprecated. Use the Transform2dArray property instead.")]
        internal void _SetTransform2dArray(Vector2[] arg0)
        {
            NativeCalls.godot_icall_1_235(method_bind_28, Object.GetPtr(this), arg0);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_transform_2d_array");

        [Obsolete("_GetTransform2dArray is deprecated. Use the Transform2dArray property instead.")]
        internal Vector2[] _GetTransform2dArray()
        {
            return NativeCalls.godot_icall_0_236(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_color_array");

        [Obsolete("_SetColorArray is deprecated. Use the ColorArray property instead.")]
        internal void _SetColorArray(Color[] arg0)
        {
            NativeCalls.godot_icall_1_231(method_bind_30, Object.GetPtr(this), arg0);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_color_array");

        [Obsolete("_GetColorArray is deprecated. Use the ColorArray property instead.")]
        internal Color[] _GetColorArray()
        {
            return NativeCalls.godot_icall_0_232(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_custom_data_array");

        [Obsolete("_SetCustomDataArray is deprecated. Use the CustomDataArray property instead.")]
        internal void _SetCustomDataArray(Color[] arg0)
        {
            NativeCalls.godot_icall_1_231(method_bind_32, Object.GetPtr(this), arg0);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_custom_data_array");

        [Obsolete("_GetCustomDataArray is deprecated. Use the CustomDataArray property instead.")]
        internal Color[] _GetCustomDataArray()
        {
            return NativeCalls.godot_icall_0_232(method_bind_33, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
