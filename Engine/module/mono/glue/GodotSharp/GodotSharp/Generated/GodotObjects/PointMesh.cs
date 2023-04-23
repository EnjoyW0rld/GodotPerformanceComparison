using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The PointMesh is made from a single point. Instead of relying on triangles, points are rendered as a single rectangle on the screen with a constant size. They are intended to be used with Particle systems, but can be used as a cheap way to render constant size billboarded sprites (for example in a point cloud).</para>
    /// <para>PointMeshes, must be used with a material that has a point size. Point size can be accessed in a shader with <c>POINT_SIZE</c>, or in a <see cref="Godot.SpatialMaterial"/> by setting <see cref="Godot.SpatialMaterial.FlagsUsePointSize"/> and the variable <see cref="Godot.SpatialMaterial.ParamsPointSize"/>.</para>
    /// <para>When using PointMeshes, properties that normally alter vertices will be ignored, including billboard mode, grow, and cull face.</para>
    /// </summary>
    public partial class PointMesh : PrimitiveMesh
    {
        private const string nativeName = "PointMesh";

        public PointMesh() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PointMesh_Ctor(this);
        }

        internal PointMesh(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
