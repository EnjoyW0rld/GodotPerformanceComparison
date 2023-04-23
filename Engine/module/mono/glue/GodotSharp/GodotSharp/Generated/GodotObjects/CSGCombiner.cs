using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>For complex arrangements of shapes, it is sometimes needed to add structure to your CSG nodes. The CSGCombiner node allows you to create this structure. The node encapsulates the result of the CSG operations of its children. In this way, it is possible to do operations on one set of shapes that are children of one CSGCombiner node, and a set of separate operations on a second set of shapes that are children of a second CSGCombiner node, and then do an operation that takes the two end results as its input to create the final shape.</para>
    /// <para>Note: CSG nodes are intended to be used for level prototyping. Creating CSG nodes has a significant CPU cost compared to creating a <see cref="Godot.MeshInstance"/> with a <see cref="Godot.PrimitiveMesh"/>. Moving a CSG node within another CSG node also has a significant CPU cost, so it should be avoided during gameplay.</para>
    /// </summary>
    public partial class CSGCombiner : CSGShape
    {
        private const string nativeName = "CSGCombiner";

        public CSGCombiner() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CSGCombiner_Ctor(this);
        }

        internal CSGCombiner(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
