using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Parent class for various CSG primitives. It contains code and functionality that is common between them. It cannot be used directly. Instead use one of the various classes that inherit from it.</para>
    /// <para>Note: CSG nodes are intended to be used for level prototyping. Creating CSG nodes has a significant CPU cost compared to creating a <see cref="Godot.MeshInstance"/> with a <see cref="Godot.PrimitiveMesh"/>. Moving a CSG node within another CSG node also has a significant CPU cost, so it should be avoided during gameplay.</para>
    /// </summary>
    public abstract partial class CSGPrimitive : CSGShape
    {
        /// <summary>
        /// <para>Invert the faces of the mesh.</para>
        /// </summary>
        public bool InvertFaces
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInvertingFaces();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInvertFaces(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CSGPrimitive";

        internal CSGPrimitive() {}

        internal CSGPrimitive(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_invert_faces");

        [GodotMethod("set_invert_faces")]
        [Obsolete("SetInvertFaces is deprecated. Use the InvertFaces property instead.")]
        public void SetInvertFaces(bool invertFaces)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), invertFaces);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_inverting_faces");

        [GodotMethod("is_inverting_faces")]
        [Obsolete("IsInvertingFaces is deprecated. Use the InvertFaces property instead.")]
        public bool IsInvertingFaces()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
