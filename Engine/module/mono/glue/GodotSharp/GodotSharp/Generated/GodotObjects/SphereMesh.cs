using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Class representing a spherical <see cref="Godot.PrimitiveMesh"/>.</para>
    /// </summary>
    public partial class SphereMesh : PrimitiveMesh
    {
        /// <summary>
        /// <para>Radius of sphere.</para>
        /// </summary>
        public float Radius
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRadius();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRadius(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Full height of the sphere.</para>
        /// </summary>
        public float Height
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHeight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHeight(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Number of radial segments on the sphere.</para>
        /// </summary>
        public int RadialSegments
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRadialSegments();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRadialSegments(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Number of segments along the height of the sphere.</para>
        /// </summary>
        public int Rings
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRings();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRings(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, a hemisphere is created rather than a full sphere.</para>
        /// <para>Note: To get a regular hemisphere, the height and radius of the sphere must be equal.</para>
        /// </summary>
        public bool IsHemisphere
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIsHemisphere();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIsHemisphere(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "SphereMesh";

        public SphereMesh() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SphereMesh_Ctor(this);
        }

        internal SphereMesh(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_radius");

        [GodotMethod("set_radius")]
        [Obsolete("SetRadius is deprecated. Use the Radius property instead.")]
        public void SetRadius(float radius)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_radius");

        [GodotMethod("get_radius")]
        [Obsolete("GetRadius is deprecated. Use the Radius property instead.")]
        public float GetRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_height");

        [GodotMethod("set_height")]
        [Obsolete("SetHeight is deprecated. Use the Height property instead.")]
        public void SetHeight(float height)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_height");

        [GodotMethod("get_height")]
        [Obsolete("GetHeight is deprecated. Use the Height property instead.")]
        public float GetHeight()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_radial_segments");

        [GodotMethod("set_radial_segments")]
        [Obsolete("SetRadialSegments is deprecated. Use the RadialSegments property instead.")]
        public void SetRadialSegments(int radialSegments)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), radialSegments);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_radial_segments");

        [GodotMethod("get_radial_segments")]
        [Obsolete("GetRadialSegments is deprecated. Use the RadialSegments property instead.")]
        public int GetRadialSegments()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rings");

        [GodotMethod("set_rings")]
        [Obsolete("SetRings is deprecated. Use the Rings property instead.")]
        public void SetRings(int rings)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), rings);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rings");

        [GodotMethod("get_rings")]
        [Obsolete("GetRings is deprecated. Use the Rings property instead.")]
        public int GetRings()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_is_hemisphere");

        [GodotMethod("set_is_hemisphere")]
        [Obsolete("SetIsHemisphere is deprecated. Use the IsHemisphere property instead.")]
        public void SetIsHemisphere(bool isHemisphere)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), isHemisphere);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_is_hemisphere");

        [GodotMethod("get_is_hemisphere")]
        [Obsolete("GetIsHemisphere is deprecated. Use the IsHemisphere property instead.")]
        public bool GetIsHemisphere()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
