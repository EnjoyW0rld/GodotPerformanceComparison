using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Class representing a cylindrical <see cref="Godot.PrimitiveMesh"/>. This class can be used to create cones by setting either the <see cref="Godot.CylinderMesh.TopRadius"/> or <see cref="Godot.CylinderMesh.BottomRadius"/> properties to <c>0.0</c>.</para>
    /// </summary>
    public partial class CylinderMesh : PrimitiveMesh
    {
        /// <summary>
        /// <para>Top radius of the cylinder. If set to <c>0.0</c>, the top faces will not be generated, resulting in a conic shape.</para>
        /// </summary>
        public float TopRadius
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTopRadius();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTopRadius(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Bottom radius of the cylinder. If set to <c>0.0</c>, the bottom faces will not be generated, resulting in a conic shape.</para>
        /// </summary>
        public float BottomRadius
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBottomRadius();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBottomRadius(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Full height of the cylinder.</para>
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
        /// <para>Number of radial segments on the cylinder. Higher values result in a more detailed cylinder/cone at the cost of performance.</para>
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
        /// <para>Number of edge rings along the height of the cylinder. Changing <see cref="Godot.CylinderMesh.Rings"/> does not have any visual impact unless a shader or procedural mesh tool is used to alter the vertex data. Higher values result in more subdivisions, which can be used to create smoother-looking effects with shaders or procedural mesh tools (at the cost of performance). When not altering the vertex data using a shader or procedural mesh tool, <see cref="Godot.CylinderMesh.Rings"/> should be kept to its default value.</para>
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

        private const string nativeName = "CylinderMesh";

        public CylinderMesh() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CylinderMesh_Ctor(this);
        }

        internal CylinderMesh(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_top_radius");

        [GodotMethod("set_top_radius")]
        [Obsolete("SetTopRadius is deprecated. Use the TopRadius property instead.")]
        public void SetTopRadius(float radius)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_top_radius");

        [GodotMethod("get_top_radius")]
        [Obsolete("GetTopRadius is deprecated. Use the TopRadius property instead.")]
        public float GetTopRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bottom_radius");

        [GodotMethod("set_bottom_radius")]
        [Obsolete("SetBottomRadius is deprecated. Use the BottomRadius property instead.")]
        public void SetBottomRadius(float radius)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), radius);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bottom_radius");

        [GodotMethod("get_bottom_radius")]
        [Obsolete("GetBottomRadius is deprecated. Use the BottomRadius property instead.")]
        public float GetBottomRadius()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_height");

        [GodotMethod("set_height")]
        [Obsolete("SetHeight is deprecated. Use the Height property instead.")]
        public void SetHeight(float height)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_height");

        [GodotMethod("get_height")]
        [Obsolete("GetHeight is deprecated. Use the Height property instead.")]
        public float GetHeight()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_radial_segments");

        [GodotMethod("set_radial_segments")]
        [Obsolete("SetRadialSegments is deprecated. Use the RadialSegments property instead.")]
        public void SetRadialSegments(int segments)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), segments);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_radial_segments");

        [GodotMethod("get_radial_segments")]
        [Obsolete("GetRadialSegments is deprecated. Use the RadialSegments property instead.")]
        public int GetRadialSegments()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rings");

        [GodotMethod("set_rings")]
        [Obsolete("SetRings is deprecated. Use the Rings property instead.")]
        public void SetRings(int rings)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), rings);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rings");

        [GodotMethod("get_rings")]
        [Obsolete("GetRings is deprecated. Use the Rings property instead.")]
        public int GetRings()
        {
            return NativeCalls.godot_icall_0_5(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
