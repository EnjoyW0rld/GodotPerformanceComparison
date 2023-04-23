using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><c>OuterProduct</c> treats the first parameter <c>c</c> as a column vector (matrix with one column) and the second parameter <c>r</c> as a row vector (matrix with one row) and does a linear algebraic matrix multiply <c>c * r</c>, yielding a matrix whose number of rows is the number of components in <c>c</c> and whose number of columns is the number of components in <c>r</c>.</para>
    /// </summary>
    public partial class VisualShaderNodeOuterProduct : VisualShaderNode
    {
        private const string nativeName = "VisualShaderNodeOuterProduct";

        public VisualShaderNodeOuterProduct() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeOuterProduct_Ctor(this);
        }

        internal VisualShaderNodeOuterProduct(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
