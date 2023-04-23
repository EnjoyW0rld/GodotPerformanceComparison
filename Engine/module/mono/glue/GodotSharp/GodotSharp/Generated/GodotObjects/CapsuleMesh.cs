using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Class representing a capsule-shaped <see cref="Godot.PrimitiveMesh"/>.</para>
    /// </summary>
    public partial class CapsuleMesh : PrimitiveMesh
    {
        /// <summary>
        /// <para>Radius of the capsule mesh.</para>
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
        /// <para>Height of the middle cylindrical part of the capsule (without the hemispherical ends).</para>
        /// <para>Note: The capsule's total height is equal to <see cref="Godot.CapsuleMesh.MidHeight"/> + 2 * <see cref="Godot.CapsuleMesh.Radius"/>.</para>
        /// </summary>
        public float MidHeight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMidHeight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMidHeight(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Number of radial segments on the capsule mesh.</para>
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
        /// <para>Number of rings along the height of the capsule.</para>
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

        private const string nativeName = "CapsuleMesh";

        public CapsuleMesh() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CapsuleMesh_Ctor(this);
        }

        internal CapsuleMesh(bool memoryOwn) : base(memoryOwn) {}

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
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mid_height");

        [GodotMethod("set_mid_height")]
        [Obsolete("SetMidHeight is deprecated. Use the MidHeight property instead.")]
        public void SetMidHeight(float midHeight)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), midHeight);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mid_height");

        [GodotMethod("get_mid_height")]
        [Obsolete("GetMidHeight is deprecated. Use the MidHeight property instead.")]
        public float GetMidHeight()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_radial_segments");

        [GodotMethod("set_radial_segments")]
        [Obsolete("SetRadialSegments is deprecated. Use the RadialSegments property instead.")]
        public void SetRadialSegments(int segments)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), segments);
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
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
